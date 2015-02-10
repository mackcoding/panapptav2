using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Panappta.Debug {
    public static class Log {
        public enum LogTypes {
            /// <summary>
            /// Normal log message
            /// </summary>
            Normal,
            /// <summary>
            /// Displays a notice
            /// </summary>
            Notice,
            /// <summary>
            /// Displays a error message
            /// </summary>
            Error,
            /// <summary>
            /// Fatal error message, must close.
            /// </summary>
            Fatal,
            /// <summary>
            /// Invalid command 
            /// Use 'strClass' as the command
            /// Use 'strFunc' as the values.
            /// 'strMsg' is NULL.
            /// </summary>
            BadCommand,
            /// <summary>
            /// Displays a message without 'strClass' and 'strFunc'
            /// </summary>
            Information
        }

        public enum Priority {
            Debug,
            Release,
            Important
        }

        public struct DebugLog {
            public string strClass, strFunction, strMessage;
            public DateTime TimeStamp;
            public Priority pLevel;
        }

        public static List<DebugLog> LogList = new List<DebugLog>();
        public static bool bUpdated = false;
        public static string LastFiveEntries = null;
        public static int ConsoleCount = 0;

        /// <summary>
        /// Displays a message into the console or error log, using "debug" priority level.
        /// </summary>    
        /// <param name="strClass">The class it occured in.</param>
        /// <param name="strFunc">The function it occured in.</param>
        /// <param name="strMsg">The message.</param>
        public static void Add(string strClass, string strFunc, string strMsg, params object[] objItems) {
            Log.Add(strClass, strFunc, strMsg, Priority.Debug, objItems);
        }


        public static void Add(string strMsg, Priority pLvl, params object[] objItems) {
            Log.Add(null, null, strMsg, pLvl, objItems);
        }

        /// <summary>
        /// Displays a message to the console log.
        /// </summary>
        /// <param name="strClass">The class name</param>
        /// <param name="strFunction">The function</param>
        /// <param name="strMessage">The message to report</param>
        /// <param name="iPriority">Priority level - "Debug", only debug mode - "Release" - only release mode, and "important" is always displayed.</param>
        /// <param name="objItems"></param>
        public static void Add(string strClass, string strFunction, string strMessage, Priority iPriority, params object[] objItems) {
            int i = 0;

            // Reset log if it is over 500
            if (LogList.Count > 500) {
                LogList.Clear();
                LogList = new List<DebugLog>();
                Log.Add("Log", "Add", "Max debug log hit. Truncated.");
            }

            foreach (object objItem in objItems) {
                if (objItem != null) {
                    strMessage = strMessage.Replace("{" + i + "}", objItem.ToString());
                    i++;
                } else {
                    strMessage = strMessage.Replace("{" + i + "}", "");
                    i++;
                }
            }

            int LastIndex = 0;

            // Trunucate if it reaches 40
            if (strMessage.Length > 60) {
                LastIndex = strMessage.Substring(0, 60).LastIndexOf(" ");
                strMessage = string.Format("{0}\n{1}", 
                    strMessage.Substring(0, LastIndex), strMessage.Substring(LastIndex, strMessage.Length-LastIndex).Trim());

            }
#if (DEBUG)
            if (LogList == null)
                LogList = new List<DebugLog>();

            DebugLog dLog = new DebugLog();
            dLog.strClass = strClass;
            dLog.strFunction = strFunction;
            dLog.strMessage = strMessage;
            dLog.TimeStamp = DateTime.Now;
            dLog.pLevel = iPriority;
            LogList.Add(dLog);


            Console.WriteLine("{0}.{1}: {2}", strClass, strFunction, strMessage, dLog.TimeStamp.TimeOfDay.ToString("T"), iPriority.ToString());
#endif
#if (!DEBUG) 
            if (iPriority == Priority.Important || iPriority == Priority.Release || iPriority == Priority.Debug) {
                if (LogList == null)
                    LogList = new List<DebugLog>();

                DebugLog dLog = new DebugLog();
                dLog.strClass = strClass;
                dLog.strFunction = strFunction;
                dLog.strMessage = strMessage;
                dLog.TimeStamp = DateTime.Now;
                dLog.pLevel = iPriority;
                LogList.Add(dLog);
            }
#endif
        }



        public static string ReturnLog {
            get {
                string strLog = null;

                for (int i = 0; i < LogList.Count; i++) {
                    if (i == 0)
                        strLog = LogList[i].strMessage;
                    else
                        strLog += "\n" + LogList[i].strMessage;
                }

                bUpdated = false;
                ClearLog();

                return (strLog);
            }
        }

        /// <summary>
        /// Clears all the logs.
        /// </summary>
        public static void ClearLog() {
            bUpdated = true;
            Log.LogList.Clear();
        }
    }
}
