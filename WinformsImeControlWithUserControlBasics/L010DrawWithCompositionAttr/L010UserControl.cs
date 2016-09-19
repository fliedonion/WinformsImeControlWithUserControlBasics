﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L010DrawWithCompositionAttr {
    public partial class L010UserControl : UserControl {
        public L010UserControl() {
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
        private bool hideCandidateWindow = false;    // L005 // L010 set false
        private string composition = "";             // L006
        private byte[] compositionAttr = null;       // L010
        private CandidateWindowForm candidateWindow = new CandidateWindowForm();  // L008

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
                    if (!hideCompositionWindow) break;  // L009
                    try {
                        hIMC = Native.ImmGetContext(Handle);

                        if ((m.LParam.ToInt64() & (long)Native.GCS_COMPATTR) == (long)Native.GCS_COMPATTR) {

                            var compLength = Native.ImmGetCompositionString(hIMC, Native.GCS_COMPATTR, (byte[])null, 0);
                            if (compLength > 0) {
                                compositionAttr = new byte[compLength];
                                Native.ImmGetCompositionString(hIMC, Native.GCS_COMPATTR, compositionAttr, compLength);
                            }
                            else {
                                compositionAttr = null;
                            }
                            Native.ImmReleaseContext(Handle, hIMC);

                            Invalidate();  // Redundancy. if you use this in production code, consider to merge L006 code.
                        }

                        #region L006
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
                        #endregion

                    }
                    finally {
                        if (hIMC != IntPtr.Zero) {
                            Native.ImmReleaseContext(Handle, hIMC);
                        }
                    }
                    break;
                case Native.WM_IME_ENDCOMPOSITION:
                    if (!hideCompositionWindow) break;  // L009
                    #region L006
                    composition = "";
                    #endregion
                    break;
                case Native.WM_IME_NOTIFY:
                    #region L008
                    switch (m.WParam.ToInt64() & 0xffff) {
                        case Native.IMN_OPENCANDIDATE:
                        case Native.IMN_CHANGECANDIDATE:
                            DisplayCandidate();
                            break;
                        case Native.IMN_CLOSECANDIDATE:
                            HideCandidate();
                            break;
                        case Native.IMN_SETOPENSTATUS:
                            break;
                    }
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
                #region L007
                var compTop = 2;

                var sizef = e.Graphics.MeasureString(composition, this.Font);
                e.Graphics.FillRectangle(new Pen(Color.Aqua).Brush, 0, compTop, sizef.Width, sizef.Height);
                #endregion

                #region L010
                e.Graphics.DrawString(composition, this.Font, new Pen(ForeColor).Brush, new PointF(0, compTop));

                if (compositionAttr != null && compositionAttr.Length > 0) {
                    var attrX = 0F;

                    var linePen = new Pen(Color.Black, 1);

                    for(var i = 0; i < compositionAttr.Length;i++){
                        if(i >= composition.Length) break;
                        
                        var charWidth = 
                            e.Graphics.MeasureString(composition.Substring(0, i+1), this.Font)
                            - e.Graphics.MeasureString(composition.Substring(0, i), this.Font);

                        switch (compositionAttr[i]) {
                            case Native.imm_ATTR_INPUT:
                                linePen.Width = 1;
                                linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                                linePen.DashOffset = 1;
                                e.Graphics.DrawLine(linePen, new PointF(attrX, compTop + sizef.Height + 1), new PointF(attrX + charWidth.Width - 1, compTop + sizef.Height + 1));
                                linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                                linePen.DashPattern=new Single[]{ 1.0f, 3.0f};
                                linePen.DashOffset = 0;
                                e.Graphics.DrawLine(linePen, new PointF(attrX, compTop + sizef.Height + 2), new PointF(attrX + charWidth.Width - 1, compTop + sizef.Height + 2));
                                linePen.DashOffset = 2;
                                e.Graphics.DrawLine(linePen, new PointF(attrX, compTop + sizef.Height), new PointF(attrX + charWidth.Width - 1, compTop + sizef.Height));

                                linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                                break;
                            case Native.imm_ATTR_TARGET_CONVERTED:
                                linePen.Width = 2;
                                e.Graphics.DrawLine(linePen, new PointF(attrX, compTop + sizef.Height), new PointF(attrX + charWidth.Width, compTop + sizef.Height));
                                linePen.Width = 1;
                                break;
                            case Native.imm_ATTR_TARGET_NOTCONVERTED:
                                linePen.Width = 1;
                                e.Graphics.DrawLine(linePen, new PointF(attrX, compTop + sizef.Height), new PointF(attrX + charWidth.Width, compTop + sizef.Height));
                                linePen.Width = 1;
                                break;
                            case Native.imm_ATTR_CONVERTED:
                                linePen.Width = 2;
                                linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                                e.Graphics.DrawLine(linePen, new PointF(attrX, compTop + sizef.Height), new PointF(attrX + charWidth.Width, compTop + sizef.Height));
                                linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                                linePen.Width = 1;
                                break;
                            case Native.imm_ATTR_FIXEDCONVERTED:
                                e.Graphics.DrawLine(Pens.Gray, new PointF(attrX, compTop + sizef.Height), new PointF(attrX + charWidth.Width, compTop + sizef.Height));
                                break;
                            default:
                                e.Graphics.DrawLine(Pens.Red, new PointF(attrX, compTop + sizef.Height), new PointF(attrX + charWidth.Width, compTop + sizef.Height));
                                break;
                        }
                        attrX += charWidth.Width;
                    }
                }
                else {
                    e.Graphics.DrawLine(new Pen(ForeColor), new PointF(0, compTop + sizef.Height), new PointF(sizef.Width, compTop + sizef.Height));
                }
                #endregion

                //#region L006  removed
                //e.Graphics.DrawString(composition, this.Font, new Pen(ForeColor).Brush, new PointF(0, compTop));
                //e.Graphics.DrawLine(new Pen(ForeColor), new PointF(0, compTop + sizef.Height), new PointF(sizef.Width, compTop + sizef.Height));
                //#endregion
                
            }
        }


        protected virtual void SetCompositionWindowPos(bool hide) {
            #region L007
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
            #endregion
        }

        protected virtual void DisplayCandidate() {
            #region L008
            var p = PointToScreen(Point.Empty);
            DisplayCandidate(p.X, p.Y + Height);
            #endregion
        }

        protected virtual void DisplayCandidate(int x, int y) {
            #region L008
            var clist = GetCandidateList();
            if (clist != null) {
                candidateWindow.Left = x;
                candidateWindow.Top = y;
                candidateWindow.CandidateList = clist;

                if (candidateWindow.Visible == false) {
                    candidateWindow.Show();
                }
            }
            else {
                candidateWindow.Hide();
            }
            #endregion
        }

        protected virtual CandidateList GetCandidateList() {
            #region L008
            var hIMC = Native.ImmGetContext(Handle);
            try {
                var size = Native.ImmGetCandidateList(hIMC, 0, null, 0);

                if (size > 0) {
                    var clist = new CandidateList();
                    var buf = new byte[size];
                    var sizeOfDWORD = 4;
                    var bytesOfEachOffset = new List<byte[]>();
                    Native.ImmGetCandidateList(hIMC, 0, buf, size);
                    clist.DwSize = BitConverter.ToInt32(buf, sizeOfDWORD * 0);
                    clist.DwStyle = BitConverter.ToInt32(buf, sizeOfDWORD * 1);
                    clist.DwCount = BitConverter.ToInt32(buf, sizeOfDWORD * 2);
                    clist.DwSelection = BitConverter.ToInt32(buf, sizeOfDWORD * 3);
                    clist.DwPageStart = BitConverter.ToInt32(buf, sizeOfDWORD * 4);
                    clist.DwPageSize = BitConverter.ToInt32(buf, sizeOfDWORD * 5);
                    for (int i = 0; i < clist.DwCount; i++) {
                        var offsetPos = BitConverter.ToInt32(buf, i * sizeOfDWORD + sizeOfDWORD * 6);
                        var l = 0;
                        if (i != clist.DwCount - 1) {
                            l = BitConverter.ToInt32(buf, (i + 1) * sizeOfDWORD + sizeOfDWORD * 6) - offsetPos;
                        }
                        else {
                            l = size - offsetPos;
                        }
                        clist.CandidateStrings.Add(Encoding.Unicode.GetString(buf, offsetPos, l));
                    }
                    return clist;
                }
                return null;
            }
            finally {
                if (hIMC != IntPtr.Zero) {
                    Native.ImmReleaseContext(Handle, hIMC);
                }
            }
            #endregion
        }

        protected virtual void HideCandidate() {
            #region L008
            candidateWindow.Hide();
            #endregion
        }

    }
}