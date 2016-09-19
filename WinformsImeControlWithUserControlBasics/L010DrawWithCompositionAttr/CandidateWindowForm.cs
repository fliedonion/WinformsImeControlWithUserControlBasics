using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformsImeControlWithUserControlBasics.L010DrawWithCompositionAttr {
    public partial class CandidateWindowForm : Form {
        public CandidateWindowForm() {
            InitializeComponent();
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ImeMode = ImeMode.Off;
            Visible = false;
            

            FormClosing += (s, e) => {
                if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.TaskManagerClosing) {
                    e.Cancel = true;
                    Hide();
                }
            };
        }

        protected override bool ShowWithoutActivation {
            get {
                return true;
            }
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams baseParams = base.CreateParams;
                baseParams.ExStyle |= (int)(Native.WS_EX_NOACTIVATE | Native.WS_EX_TOOLWINDOW | Native.WS_EX_TOPMOST);
                return baseParams;
            }
        }

        public CandidateList CandidateList {
            set {
                candidateListBox.Items.Clear();

                if (value.DwPageSize == 0) {
                    candidateListBox.Items.AddRange(value.CandidateStrings.Select(x => (object)x).ToArray());
                    candidateListBox.SelectedIndex = value.DwSelection;
                }
                else {
                    var willSelect = 0;
                    for (var i = value.DwPageStart; i < value.DwPageStart + value.DwPageSize; i++) {
                        candidateListBox.Items.Add(value.CandidateStrings[i]);
                        if (i == value.DwSelection) {
                            willSelect = i - value.DwPageStart;
                        }
                    }
                    candidateListBox.SelectedIndex = willSelect;
                }
            }
        }
    }
}
