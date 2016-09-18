namespace WinformsImeControlWithUserControlBasics.L006DrawCompositionText {
    partial class L006Form {
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
            this.l006UserControl1 = new WinformsImeControlWithUserControlBasics.L006DrawCompositionText.L006UserControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "変換中テキストが表示される事の確認";
            // 
            // l006UserControl1
            // 
            this.l006UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l006UserControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l006UserControl1.Location = new System.Drawing.Point(68, 101);
            this.l006UserControl1.Name = "l006UserControl1";
            this.l006UserControl1.Size = new System.Drawing.Size(450, 67);
            this.l006UserControl1.TabIndex = 7;
            // 
            // L006Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 220);
            this.Controls.Add(this.l006UserControl1);
            this.Controls.Add(this.label1);
            this.Name = "L006Form";
            this.Text = "L006Form";
            this.Load += new System.EventHandler(this.L006Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private L006UserControl l006UserControl1;
    }
}