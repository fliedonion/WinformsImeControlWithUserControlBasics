namespace WinformsImeControlWithUserControlBasics.L010DrawWithCompositionAttr {
    partial class L010Form {
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
            this.l010UserControl1 = new WinformsImeControlWithUserControlBasics.L010DrawWithCompositionAttr.L010UserControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l010UserControl1
            // 
            this.l010UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l010UserControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l010UserControl1.Location = new System.Drawing.Point(45, 60);
            this.l010UserControl1.Name = "l010UserControl1";
            this.l010UserControl1.Size = new System.Drawing.Size(450, 40);
            this.l010UserControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "変換中テキストの属性に応じた下線を適当に。";
            // 
            // L010Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l010UserControl1);
            this.Name = "L010Form";
            this.Text = "L010Form";
            this.Load += new System.EventHandler(this.L010Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private L010UserControl l010UserControl1;
        private System.Windows.Forms.Label label1;
    }
}