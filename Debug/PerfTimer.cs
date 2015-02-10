using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Web;
using System.Threading;

// Code derived from http://www.codeproject.com/KB/cs/highperformancetimercshar.aspx

namespace Panappta.Debug {
    /// <summary>
    /// Accurate performance timer 
    /// </summary>
    public class PerfTimer {
#if __MonoCS__
// ToDo: Implement Linux timing methods. 
#else
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(
            out long lpPerformanceCount);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(
            out long lpFrequency);

        private long startTime, stopTime, timerFreq;
        private Decimal multiplier = new Decimal(1.0e9);


        public PerfTimer() {
            startTime = 0;
            stopTime = 0;


            if (QueryPerformanceFrequency(out timerFreq) == false) {
                ErrorReport eReport = new ErrorReport("PerfTimer", "Initialize()",
                    "High-performance timer is not supported on this system.", new Exception());
            }

        }

        public long TimerFreq {
            get {
                return (timerFreq);
            }
        }

        public void Start() {
            Thread.Sleep(0);

            QueryPerformanceCounter(out startTime);
        }

        public void Stop() {

            QueryPerformanceCounter(out stopTime);

        }

        public double Duration(int iterations) {
            return ((((double)(stopTime - startTime) *
                      (double)multiplier) /
                      (double)timerFreq) / iterations);
        }

        public bool SecondElapsed {
            get {

                return (true);
            }
        }

        public double Seconds {
            get {
                int interval = 1;

                return (Duration(interval) * 0.000000001);
            }
        }

        public double StartTime {
            get {
                return ((startTime / 1000));
            }
        }

        public double StopTime {
            get {
                return ((stopTime / 1000));
            }
        }
#endif

    }
}
