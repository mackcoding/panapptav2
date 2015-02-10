using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Panappta.Debug;
using Panappta.Core.Services;

namespace Panappta.Core {
    /// <summary>
    /// Handles the internal clock that processes the tasks. 
    /// </summary>
    public class ITimerHandler {

        #region Enums
        /// <summary>
        /// List of controls available
        /// </summary>
        public enum ControlType {
            ListView,
            Label,
            TextBox
        }

        /// <summary>
        /// List of tasks run types
        /// </summary>
        public enum TaskRunTypes {
            Panopta,
            UptimeRobot,
            Zen,
            DisplayBubble,
            UpdateCheck
        }

        #endregion

        #region Global Classes
        System.Timers.Timer RunTimer = new System.Timers.Timer(15000); // Run the tasks every 15 seconds. 
        List<ITasks> TaskItems = new List<ITasks>();
        Form fMain;
        #endregion

        /// <summary>
        /// Initializes the internal timer class. 
        /// </summary>
        /// <param name="bAutoStart">T/F - Set true to start timer right away.</param>
        public ITimerHandler(bool bAutoStart, Form frmMain) {
            Log.Add("ITimerHandler", "Init", "Class set set to autostart: {0}, reference form {1}", bAutoStart, frmMain.ToString());
            
            if (bAutoStart)
                RunTimer.Start();

            fMain = frmMain;
            RunTimer.Elapsed += RunTimer_Elapsed;


        }

        /// <summary>
        /// Runs each time the timer is elapsed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RunTimer_Elapsed(object sender, ElapsedEventArgs e) {
            ((frmMain)fMain).UpdateStatus("Processing tasks..");
            foreach (ITasks _TASK in TaskItems.ToList()) { // Loop through the task list
                ((frmMain)fMain).UpdateStatus(string.Format("Processing task '{0}'...", _TASK.TaskName)); // Update the task status
                if (TimeElapsed(_TASK.NextRun, _TASK.RunTimeHours, _TASK.RunTimeMinutes)) { 
                    Log.Add("ITimerHandler", "RunTimer_Elapsed", "Running task '{0}'", Log.Priority.Debug, _TASK.TaskName);
                    ProcessTask(_TASK);
                    UpdateTask(TaskItems.IndexOf(_TASK), _TASK);
                }
            }
            ((frmMain)fMain).UpdateStatus(string.Format("Tasks completed, last run {0}", DateTime.Now));
        }

        /// <summary>
        /// Processes the tasks based on specified task type
        /// </summary>
        /// <param name="_ITEM">The type of task to run</param>
        void ProcessTask(ITasks _ITEM) {

            // Lets decide wtf the task does
            switch (_ITEM.TaskRunType) {
                case TaskRunTypes.UpdateCheck: // Check for updates.. 
                    UpdateHandler uHandler = new UpdateHandler(); // Create a new updater handler
                    Log.Add("ITimerHandler", "ProcessTask[UpdateCheck]", "Checking for updates..");  
                    if (uHandler.CheckForUpdates()) { // I done did derped. 
                        Log.Add("ITimerHandler", "ProcessTask[UpdateCheck]", "An error occurred while checking for updates!");
                        return;
                    } else
                        if (uHandler.UpdateAvailable) { // Run updater
                            Log.Add("ITimerHandler", "ProcessTask[UpdateCheck]", "An update is available.");
                            frmUpdate fUpdate = new frmUpdate();
                            fUpdate.ShowDialog();
                        } else
                            Log.Add("ITimerHandler", "ProcessTask[UpdateCheck]", "No updates available.");
                    break;
                case TaskRunTypes.Panopta: // Run panopta..
                    Log.Add("ITimerHandler", "ProcessTask", "Processing Panopta task...");
                    RunPanopta((ListView)_ITEM.ControlItem1);
                    break;
                case TaskRunTypes.DisplayBubble: // Display da bubblez!
                    Log.Add("ITimerHandler", "ProcessTask", "Processing notification task...");
                    ((frmMain)fMain).DisplayBubble();
                    Log.Add("ITimerHandler", "ProcessTask", "Notification task completed. ");
                    break;
            }
        }

        /// <summary>
        /// Runs the panopta task and parses the json
        /// </summary>
        /// <param name="lView"></param>
        public void RunPanopta(ListView lView) {
            Panopta pJson = new Panopta();
            RootObject obj = pJson.ParsePanopta();
            PanoptaList = obj;
            ((frmMain)fMain).UpdatePanopta();

            Log.Add("ITimerHandler", "RunPanopta", "Panopta task ran successfully.");
        }

        public RootObject PanoptaList { get; set; }

        public int FindPanoptaIndex(string Name) {
            int index = PanoptaList.outage_list.FindIndex(delegate(OutageList t) { return t.server_name.ToLower().Equals(Name.ToLower()); });

            Log.Add("ITimerHandler", "FindPanoptaIndex", "Index: {0}", index);

            return index;
        }

        /// <summary>
        /// Removes the old task and updates it with updated statistics
        /// </summary>
        /// <param name="index">Index of the task to update</param>
        /// <param name="_ITEM">The task item</param>
        void UpdateTask(int index, ITasks _ITEM) {
            ITasks tmp = _ITEM;

            tmp.CurrentCount++;
            tmp.LastRun = DateTime.Now;
            tmp.NextRun = DateTime.Now.AddHours(tmp.RunTimeHours).AddMinutes(tmp.RunTimeMinutes);


            if (tmp.MaxRunCount > 0) // Check if we need to just delete the task
                if (tmp.CurrentCount >= tmp.MaxRunCount) {
                    Log.Add("ITimerHandler", "UpdateTask", "Removed task {0}({1})", Log.Priority.Debug, tmp.TaskName, index);
                    TaskItems.RemoveAt(index);
                    return;
                }

            TaskItems.RemoveAt(index);
            TaskItems.Add(tmp);

            Log.Add("ITimerHandler", "UpdateTask", "Updated task '{0}'", tmp.TaskName);
        }

        /// <summary>
        /// Returns true if the time elapsed (if it's true, task needs to run)
        /// </summary>
        /// <param name="NextRun"></param>
        /// <param name="H"></param>
        /// <param name="M"></param>
        /// <returns></returns>
        bool TimeElapsed(DateTime NextRun, int H, int M) {
            DateTime startTime = DateTime.Now.AddMinutes(M);
            TimeSpan tSpan = startTime.Subtract(NextRun);

            if (Math.Round(tSpan.TotalHours) >= 0 && tSpan.Minutes >= M)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Adds a new task
        /// </summary>
        /// <param name="TaskName">Name of the task (for debug console)</param>
        /// <param name="TaskType">Type of task we are running</param>
        /// <param name="RunTimeMinutes">How many minutes until the task runs</param>
        /// <param name="RunTimeHours">How many hours until next task run</param>
        /// <param name="RunCount">Number of times the task needs to run, set 0 for infinite</param>
        /// <param name="ControlItem1">ControlItem1</param>
        /// <param name="ControlItem2">ControlItem2</param>
        /// <param name="CItem1">CItem1 Type</param>
        /// <param name="CItem2">CItem2 Type</param>
        public void AddTask(string TaskName, TaskRunTypes TaskType,
            int RunTimeMinutes, int RunTimeHours, int RunCount, Control ControlItem1, Control ControlItem2, ControlType CItem1, ControlType CItem2) {
            ITasks tmp = new ITasks();
            tmp.TaskName = TaskName;
            tmp.TaskRunType = TaskType;
            tmp.LastRun = DateTime.Now.Subtract(new TimeSpan(48, 0, 0));
            tmp.NextRun = DateTime.Now.Add(new TimeSpan(RunTimeHours, RunTimeMinutes, 0));
            tmp.MaxRunCount = RunCount;
            tmp.CurrentCount = 0;
            tmp.RunTimeHours = RunTimeHours;
            tmp.RunTimeMinutes = RunTimeMinutes;
            tmp.ControlItem1 = ControlItem1;
            tmp.ControlItem2 = ControlItem2;
            tmp._ControlItem1Type = CItem1;
            tmp._ControlItem2Type = CItem2;

            TaskItems.Add(tmp);

            Log.Add("ITimerHandler", "AddTask", "Added new task '{0}'", TaskName);
        }

        public void ClearTasks() {
            Log.Add("ITimerHandler", "ClearTasks", "Tasks cleared.");
            TaskItems.Clear();
        }

        public Panopta PanoptaItems { get; set; }

    }


    /// <summary>
    /// Holds the struct for internal classes.
    /// </summary>
    internal class ITasks {
        public string TaskName; // Name of the task
        public ITimerHandler.TaskRunTypes TaskRunType; // Type of task we are running
        public DateTime LastRun; // The last time the task ran
        public DateTime NextRun; // The next run
        public int MaxRunCount; // Specifies how many times it can run, infinite is 0
        public int CurrentCount; // Number of runs for the task
        public int RunTimeMinutes; // The number of times it runs in minutes
        public int RunTimeHours; // The number of times it runs in hours
        public Control ControlItem1; // Control1 we need to interact with
        public Control ControlItem2; // Control2 we need to interact with 
        public ITimerHandler.ControlType _ControlItem1Type; // Control1 type
        public ITimerHandler.ControlType _ControlItem2Type; // Control2 type
    }
}
