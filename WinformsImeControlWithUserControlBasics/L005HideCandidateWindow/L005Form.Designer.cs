namespace WinformsImeControlWithUserControlBasics.L005HideCandidateWindow {
    partial class L005Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.l005UserControl1 = new WinformsImeControlWithUserControlBasics.L005HideCandidateWindow.L005UserControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "変換中ウィンドウが表示されないことを確認";
            // 
            // l005UserControl1
            // 
            this.l005UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l005UserControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l005UserControl1.Location = new System.Drawing.Point(60, 81);
            this.l005UserControl1.Name = "l005UserControl1";
            this.l005UserControl1.Size = new System.Drawing.Size(450, 40);
            this.l005UserControl1.TabIndex = 6;
            // 
            // L005Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 241);
            this.Controls.Add(this.l005UserControl1);
            this.Controls.Add(this.label1);
            this.Name = "L005Form";
            this.Text = "L005Form";
            this.Load += new System.EventHandler(this.L005Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private L005UserControl l005UserControl1;
    }
}