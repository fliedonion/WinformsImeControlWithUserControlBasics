using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L002AcceptText {
    public partial class L002Form : Form {
        public L002Form() {
            InitializeComponent();
        }

        private void L002Form_Load(object sender, EventArgs e) {
            l002UserControl1.Focus();
            l002UserControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            l002UserControl1.OnTextChange += l002UserControl1_OnTextChange;
        }

        void l002UserControl1_OnTextChange(object sender, EventArgs e) {
            outLabel.Text = l002UserControl1.Text;
        }
    }
}
