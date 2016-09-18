namespace WinformsImeControlWithUserControlBasics.L002AcceptText {
    partial class L002Form {
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
            this.l002UserControl1 = new WinformsImeControlWithUserControlBasics.L002AcceptText.L002UserControl();
            this.outLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l002UserControl1
            // 
            this.l002UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l002UserControl1.Location = new System.Drawing.Point(58, 91);
            this.l002UserControl1.Name = "l002UserControl1";
            this.l002UserControl1.Size = new System.Drawing.Size(450, 40);
            this.l002UserControl1.TabIndex = 0;
            // 
            // outLabel
            // 
            this.outLabel.BackColor = System.Drawing.Color.White;
            this.outLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outLabel.Location = new System.Drawing.Point(58, 182);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(450, 39);
            this.outLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "確定した文字列が下のラベルに表示されることを確認";
            // 
            // L002Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.l002UserControl1);
            this.Name = "L002Form";
            this.Text = "L002Form";
            this.Load += new System.EventHandler(this.L002Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private L002UserControl l002UserControl1;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Label label1;
    }
}