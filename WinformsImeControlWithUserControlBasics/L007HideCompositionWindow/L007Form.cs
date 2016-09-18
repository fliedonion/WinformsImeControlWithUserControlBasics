using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L007HideCompositionWindow {
    public partial class L007Form : Form {
        public L007Form() {
            InitializeComponent();
        }

        private void L007Form_Load(object sender, EventArgs e) {
            l007UserControl1.Focus();
            l007UserControl1.ImeMode = System.Windows.Forms.ImeMode.On;
        }
    }
}
