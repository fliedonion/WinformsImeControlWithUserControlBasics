using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L007HideCompositionWindow {
    public partial class L007UserControl : UserControl {
        public L007UserControl() {
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

        public event EventHandler OnTextChange;      // L002
        private bool hideCompositionWindow = true;   // L007
        private bool hideCandidateWindow = true;     // L005
        private string composition = "";             // L006

        protected virtual void InitControl() {
            #region L001
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            #endregion
        }

        protected override Size DefaultSize {
            #region L001
            get {
                return new Size(450, 40);
            }
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
                    #region L004
                    m.Result = IntPtr.Zero;
                    SetCompositionWindowPos(hideCompositionWindow);
                    Focus();
                    #endregion
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
                case Native.WM_IME_SETCONTEXT:
                    #region L005
                    if (hideCandidateWindow) {
                        // Ignore Messages for hide candidate window
                        m.LParam = IntPtr.Zero;
                        DefWndProc(ref m);
                        return;
                    }
                    #endregion
                    break;
                case Native.WM_IME_STARTCOMPOSITION:
                    break;
                case Native.WM_IME_COMPOSITION:
                    #region L006
                    try {
                        hIMC = Native.ImmGetContext(Handle);

                        if ((m.LParam.ToInt64() & (long)Native.GCS_COMPSTR) == (long)Native.GCS_COMPSTR) {

                            var textBuff = "";
                            var compLength = Native.ImmGetCompositionString(hIMC, Native.GCS_COMPSTR, (byte[])null, 0);
                            if (compLength > 0) {
                                var temp = new byte[compLength];
                                Native.ImmGetCompositionString(hIMC, Native.GCS_COMPSTR, temp, compLength);
                                textBuff = Encoding.Unicode.GetString(temp);
                                composition = textBuff;
                            }
                            Native.ImmReleaseContext(Handle, hIMC);

                            if (!Focused) {
                                composition = "";
                            }

                            if (composition != "" && ImeMode == ImeMode.Off) {
                                composition = "";
                            }

                            Invalidate();
                        }

                        if ((m.LParam.ToInt64() & (long)Native.GCS_RESULTSTR) == (long)Native.GCS_RESULTSTR) {
                        }


                    }
                    finally {
                        if (hIMC != IntPtr.Zero) {
                            Native.ImmReleaseContext(Handle, hIMC);
                        }
                    }
                    #endregion
                    break;
                case Native.WM_IME_ENDCOMPOSITION:
                    #region L006
                    composition = "";
                    #endregion
                    break;
            }
            base.WndProc(ref m);
        }

        protected override void OnPaint(PaintEventArgs e) {
            #region L003
            base.OnPaint(e);

            e.Graphics.DrawString(Text, this.Font, new Pen(ForeColor).Brush, new PointF(2, 2));
            #endregion

            if (composition != "") {

                var compTop = 2; // L007 Update Own drawing composition location


                var sizef = e.Graphics.MeasureString(composition, this.Font);
                e.Graphics.FillRectangle(new Pen(Color.Aqua).Brush, 0, compTop , sizef.Width, sizef.Height);

                #region L006
                e.Graphics.DrawString(composition, this.Font, new Pen(ForeColor).Brush, new PointF(0, compTop));

                // var sizef = e.Graphics.MeasureString(composition, this.Font); // L007 moved.
                e.Graphics.DrawLine(new Pen(ForeColor), new PointF(0, compTop + sizef.Height), new PointF(sizef.Width, compTop + sizef.Height));
                #endregion
            }
        }


        protected virtual void SetCompositionWindowPos(bool hide) {
            var hIMC = Native.ImmGetContext(this.Handle);
            try {
                var cf = new Native.COMPOSITIONFORM();
                if (!hide) {
                    #region L004
                    cf.ptCurrentPos.x = 50;
                    cf.ptCurrentPos.y = 0;
                    cf.dwStyle = Native.CFS_POINT;
                    #endregion
                }
                else {
                    cf.ptCurrentPos.x = 0;
                    cf.ptCurrentPos.y = 0;
                    cf.rcArea._Top = 0;
                    cf.rcArea._Left = 0;
                    // I don't why,  set small values to Bottom and Right, composition window will disappear.
                    cf.rcArea._Bottom = 1;  
                    cf.rcArea._Right = 1;
                    cf.dwStyle = Native.CFS_RECT;
                }

                if (hIMC != IntPtr.Zero) {
                    Native.ImmSetCompositionWindow(hIMC, ref cf);
                }
            }
            finally {
                if (hIMC != IntPtr.Zero) {
                    Native.ImmReleaseContext(this.Handle, hIMC);
                }
            }

            #region L004 - Replaced
            //var hIMC = Native.ImmGetContext(this.Handle);
            //try {
            //    var cf = new Native.COMPOSITIONFORM();
            //    cf.ptCurrentPos.x = 50;
            //    cf.ptCurrentPos.y = 0;
            //    cf.dwStyle = Native.CFS_POINT;

            //    if (hIMC != IntPtr.Zero) {
            //        Native.ImmSetCompositionWindow(hIMC, ref cf);
            //    }
            //}
            //finally {
            //    if (hIMC != IntPtr.Zero) {
            //        Native.ImmReleaseContext(this.Handle, hIMC);
            //    }
            //}
            #endregion
        }
    }
}
