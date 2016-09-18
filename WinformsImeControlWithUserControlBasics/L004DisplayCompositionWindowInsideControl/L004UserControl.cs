using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L004DisplayCompositionWindowInsideControl {
    public partial class L004UserControl : UserControl {
        public L004UserControl() {
            InitializeComponent();
            InitControl();
        }

        protected override bool CanEnableIme {
            #region L001
            get {
                return true;
            }
            #endregion
        }

        public event EventHandler OnTextChange;  // L002

        protected virtual void InitControl() {
            #region L001
            this.Height = 40;
            this.Width = 450;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            #endregion
        }

        public override string Text {
            #region L002
            get {
                return base.Text;
            }
            set {
                base.Text = value;
                if (OnTextChange != null) {
                    OnTextChange(this, new EventArgs());
                }
            }
            #endregion
        }

        protected override void WndProc(ref Message m) {
            IntPtr hIMC = IntPtr.Zero;
            switch (m.Msg) {
                case Native.WM_SETFOCUS:
                    m.Result = IntPtr.Zero;
                    SetCompositionWindowPos();
                    Focus();
                    break;
                case Native.WM_CHAR:
                    #region L003
                    hIMC = Native.ImmGetContext(this.Handle);
                    if (Native.ImmGetOpenStatus(hIMC)) {
                        char chr = Convert.ToChar(m.WParam.ToInt64() & 0xffff);

                        if (m.WParam.ToInt64() >= 32) {
                            string str = chr.ToString();
                            this.Text += str;
                        }
                    }
                    Native.ImmReleaseContext(this.Handle, hIMC);
                    Invalidate();
                    #endregion
                    break;
            }
            base.WndProc(ref m);
        }

        #region L003
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            e.Graphics.DrawString(Text, this.Font, new Pen(ForeColor).Brush, new PointF(2, 2));

        }
        #endregion 


        public void SetCompositionWindowPos() {
            var hIMC = Native.ImmGetContext(this.Handle);
            try {
                var cf = new Native.COMPOSITIONFORM();
                cf.ptCurrentPos.x = 50;
                cf.ptCurrentPos.y = 0;
                cf.dwStyle = Native.CFS_POINT;

                if (hIMC != IntPtr.Zero) {
                    Native.ImmSetCompositionWindow(hIMC, ref cf);
                }
            }
            finally {
                if (hIMC != IntPtr.Zero) {
                    Native.ImmReleaseContext(this.Handle, hIMC);
                }
            }
        }

    }
}
