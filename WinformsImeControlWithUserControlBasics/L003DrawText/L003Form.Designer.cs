namespace WinformsImeControlWithUserControlBasics.L003DrawText {
    partial class L003Form {
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
            this.l003UserControl1 = new WinformsImeControlWithUserControlBasics.L003DrawText.L003UserControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "確定した文字列がコントロールに描画されること";
            // 
            // l003UserControl1
            // 
            this.l003UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l003UserControl1.Location = new System.Drawing.Point(50, 80);
            this.l003UserControl1.Name = "l003UserControl1";
            this.l003UserControl1.Size = new System.Drawing.Size(450, 40);
            this.l003UserControl1.TabIndex = 5;
            // 
            // L003Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 190);
            this.Controls.Add(this.l003UserControl1);
            this.Controls.Add(this.label1);
            this.Name = "L003Form";
            this.Text = "L003Form";
            this.Load += new System.EventHandler(this.L003Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private L003UserControl l003UserControl1;
    }
}