namespace WinformsImeControlWithUserControlBasics.L001OverrideCanEnableIme {
    partial class L001Form {
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
            this.l001UserControl1 = new WinformsImeControlWithUserControlBasics.L001OverrideCanEnableIme.L001UserControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type して IME が（どこかに）出現することを確認";
            // 
            // l001UserControl1
            // 
            this.l001UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l001UserControl1.Location = new System.Drawing.Point(60, 69);
            this.l001UserControl1.Name = "l001UserControl1";
            this.l001UserControl1.Size = new System.Drawing.Size(450, 40);
            this.l001UserControl1.TabIndex = 0;
            // 
            // L001Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 182);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l001UserControl1);
            this.Name = "L001Form";
            this.Text = "L01Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private L001UserControl l001UserControl1;
        private System.Windows.Forms.Label label1;

    }
}