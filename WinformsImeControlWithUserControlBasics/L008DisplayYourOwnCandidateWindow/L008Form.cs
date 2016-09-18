using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L008DisplayYourOwnCandidateWindow {
    public partial class L008Form : Form {
        public L008Form() {
            InitializeComponent();
        }

        private void L008Form_Load(object sender, EventArgs e) {
            l008UserControl1.Focus();
            l008UserControl1.ImeMode = System.Windows.Forms.ImeMode.On;
        }
    }
}
