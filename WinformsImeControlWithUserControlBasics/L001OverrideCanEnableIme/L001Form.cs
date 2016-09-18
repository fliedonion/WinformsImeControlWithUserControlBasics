using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L001OverrideCanEnableIme {
    public partial class L001Form : Form {
        public L001Form() {
            InitializeComponent();


            l001UserControl1.Focus();
            l001UserControl1.ImeMode = System.Windows.Forms.ImeMode.On;

        }
    }
}
