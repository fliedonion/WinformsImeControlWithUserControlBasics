using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L003DrawText {
    public partial class L003Form : Form {
        public L003Form() {
            InitializeComponent();
        }

        private void L003Form_Load(object sender, EventArgs e) {
            l003UserControl1.Focus();
            l003UserControl1.ImeMode = System.Windows.Forms.ImeMode.On;
        }
    }
}
