using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L005HideCandidateWindow {
    public partial class L005Form : Form {
        public L005Form() {
            InitializeComponent();
        }

        private void L005Form_Load(object sender, EventArgs e) {
            l005UserControl1.Focus();
            l005UserControl1.ImeMode = System.Windows.Forms.ImeMode.On;
        }
    }
}
