﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Panappta {
    public partial class frmAlert : Form {
        public frmAlert() {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
