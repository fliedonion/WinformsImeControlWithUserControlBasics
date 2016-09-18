using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L006DrawCompositionText {
    public partial class L006Form : Form {
        public L006Form() {
            InitializeComponent();
        }

        private void L006Form_Load(object sender, EventArgs e) {
            l006UserControl1.Focus();
            l006UserControl1.ImeMode = System.Windows.Forms.ImeMode.On;
        }

    }
}
