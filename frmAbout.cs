using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Panappta {
    public partial class frmAbout : Form {
        public frmAbout() {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e) {
            rtfAbout.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Segoe UI Semilight;}}
{\colortbl ;\red0\green0\blue255;}
{\*\generator Riched20 6.3.9600}\viewkind4\uc1 
\pard\sa200\sl276\slmult1\b\f0\fs18\lang9 Panappta \b0\i version\i0\par
\i Panappta\i0  is an alert application designed to alert Hosting employees about outages. Panappta is written in C# using the .NET Framework 4.0. \i Panappta\i0  is an open-source application written by Thomas Mack, for use as an internal application within the Hosting network. \par
For more information visit {{\field{\*\fldinst{HYPERLINK http://tools.mackcoding.com/panappta/ }}{\fldrslt{http://tools.mackcoding.com/panappta/\ul0\cf0}}}}\f0\fs18  \par
\b\fs28 Credits\b0\fs18\line\b Thomas Mack \b0 - Programming\line\b Corey Johnson \b0 - Testing & Suggestions\line\b Ashley Hayward \b0 - Testing & Suggestions\line\b Keith Walls \b0 - Testing & Suggestions\line\b Regan Laitila \b0 - Testing & Suggestions\line\line\b\fs28 Other Credits\fs18\line\b0 Panopta - {{\field{\*\fldinst{HYPERLINK http://panopta.com }}{\fldrslt{http://panopta.com\ul0\cf0}}}}\f0\fs18\line Uptime  Robot - {{\field{\*\fldinst{HYPERLINK http://www.uptimerobot.com }}{\fldrslt{http://www.uptimerobot.com\ul0\cf0}}}}\b\f0\fs18\line\b0 Json.NET - {{\field{\*\fldinst{HYPERLINK http://james.newtonking.com/json }}{\fldrslt{http://james.newtonking.com/json\ul0\cf0}}}}\f0\fs18  \par
}";
#if (DEBUG)
            rtfAbout.Rtf = rtfAbout.Rtf.Replace("version", Application.ProductVersion + " - Debug");
#else
            rtfAbout.Rtf = rtfAbout.Rtf.Replace("version", Application.ProductVersion + " - Release");
#endif
        }

        private void cmdOK_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
