using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L009ShowOwnCompositionOnlyHideImeOne {
    public partial class L009Form : Form {
        public L009Form() {
            InitializeComponent();
        }

        private void L009Form_Load(object sender, EventArgs e) {
            l009UserControl1.Focus();
            l009UserControl1.ImeMode = System.Windows.Forms.ImeMode.On;
        }
    }
}
