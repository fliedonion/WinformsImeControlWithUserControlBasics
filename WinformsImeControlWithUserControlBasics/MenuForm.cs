using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WinformsImeControlWithUserControlBasics.L001OverrideCanEnableIme;

namespace WinformsImeControlWithUserControlBasics {
    public partial class MenuForm : Form {
        public MenuForm() {
            InitializeComponent();

            AddToDictIfFormExists("L001", "Create UserControl That Support IME");
            AddToDictIfFormExists("L002", "Accept IME Result Text");
            AddToDictIfFormExists("L003", "DrawText");
            AddToDictIfFormExists("L004", "DisplayCompositionWindowInsideControl");
            AddToDictIfFormExists("L005", "HideCandidateWindow");
            AddToDictIfFormExists("L006", "DrawCompositionText");
            AddToDictIfFormExists("L007", "HideCompositionWindow");
            AddToDictIfFormExists("L008", "DisplayYourOwnCandidateWindow");
            AddToDictIfFormExists("L009", "ShowOwnCompositionOnlyHideImeOne");

            CreateButtons();

        }

        private void CreateButtons() {
            var top = 10;
            var height = 30;
            var width = 260;
            var left = 30;

            panel1.SuspendLayout();

            foreach (var key in keyDescriptionDict.Keys) {
                if (keyDescriptionDict.ContainsKey(key)) {
                    var btn = new Button {
                        Name = key + "Button",
                        Text = key + " : " + keyDescriptionDict[key],
                        TextAlign = ContentAlignment.MiddleLeft,
                        Top = top,
                        Left = left,
                        Width = width,
                        Height = height,
                        AutoSize = true,
                        Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                        Visible = true,
                    };

                    btn.Click += (s, ev) => {
                        CreateFormStartsWithLessonNumber(key).ShowDialog();
                    };

                    panel1.Controls.Add(btn);
                    top += height + 10;
                }
            }
            panel1.ResumeLayout(true);
        }

        private void MenuForm_Load(object sender, EventArgs e) {


        }

        private const string FormSuffix = "Form";

        private Form CreateFormStartsWithLessonNumber(string key) {
            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetTypes().First(t => t.Name == key + FormSuffix);
            return (Form)Activator.CreateInstance(type);
        }

        private Dictionary<string, string> keyDescriptionDict = new Dictionary<string, string>();

        private void AddToDictIfFormExists(string key, string description) {
            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetTypes().FirstOrDefault(t => t.Name == key + FormSuffix);
            if (type != null) {
                keyDescriptionDict.Add(key, description);
            }
        }

    }
}
