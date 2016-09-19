using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L010DrawWithCompositionAttr {
    public partial class L010Form : Form {
        public L010Form() {
            InitializeComponent();
        }

        private void L010Form_Load(object sender, EventArgs e) {
            l010UserControl1.Focus();
            l010UserControl1.ImeMode = System.Windows.Forms.ImeMode.On;
        }
    }
}
