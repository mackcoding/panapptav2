using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Management;
using Panappta;
using System.Text.RegularExpressions;

namespace Panappta.Debug {

    public class ErrorReport {
        public struct ErrorDetails {
            public string strMessage;
            public string strClass;
            public string strFunc;
            public Exception Excep;
        }

        public ErrorReport(string strClass, string strFunction, string strMessage, Exception exception) {
            ErrorDetails t = new ErrorDetails();
            t.strClass = strClass;
            t.strFunc = strFunction;
            t.strMessage = strMessage;
            t.Excep = exception;

            AddError(t);
        }

        public void AddError(ErrorDetails eDetails) {
            string strMsg = null;

            if (eDetails.strMessage == null)
                eDetails.strMessage = eDetails.Excep.Message;

          //  strMsg = String.Format("Fatal Error occured in '{0}' at function '{1}' with message: '{2}'\n\nSTACK TRACE\n{3}\n{4}\n\nCONSOLE LOG{5}",
          //      eDetails.strClass, eDetails.strFunc, eDetails.strMessage, eDetails.Excep.StackTrace, GetSystemInfo, "");

            strMsg = String.Format("A fatal error occurred in class \"{0}\" at method \"{1}\".\n{2}", eDetails.strClass, eDetails.strFunc, eDetails.Excep.Message);
            strMsg += String.Format("\n\n---OPERATING SYSTEM INFORMATION---\n\n{0}\n\n---END OF OPERATING SYSTEM INFORMATION---\n\n", GetSystemInfo);
            
            if (eDetails.Excep.StackTrace != null)
                strMsg += String.Format("\n\n---STACK TRACE---\n\n{0}\n\n---END OF STACK TRACE---\n\n", eDetails.Excep.StackTrace);



#if (!DEBUG)

            frmError fError = new frmError();
            fError.SetErrorBox(strMsg);
            fError.SetTopError(eDetails.strMessage);
            fError.ShowDialog();
#else
            Console.WriteLine("---ERROR OCCURED---\n {0}", eDetails.strMessage);
            Console.WriteLine(strMsg);
            Log.Add("---ERROR OCCURED---\n {0}\n{1}", Log.Priority.Important, eDetails.strMessage, strMsg);
           // Console.ReadLine();

#endif
        }

        private string GetSystemInfo {
            get {
                return null;
            }
        }

    }
}
