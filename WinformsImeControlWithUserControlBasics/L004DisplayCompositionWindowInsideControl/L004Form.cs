using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L004DisplayCompositionWindowInsideControl {
    public partial class L004Form : Form {
        public L004Form() {
            InitializeComponent();
        }

        private void L004Form_Load(object sender, EventArgs e) {
            l004UserControl1.Focus();
            l004UserControl1.ImeMode = System.Windows.Forms.ImeMode.On;
        }
    }
}
