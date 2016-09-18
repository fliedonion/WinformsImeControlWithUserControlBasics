namespace WinformsImeControlWithUserControlBasics.L008DisplayYourOwnCandidateWindow {
    partial class L008Form {
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
            this.l008UserControl1 = new WinformsImeControlWithUserControlBasics.L008DisplayYourOwnCandidateWindow.L008UserControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "独自変換ウィンドウが表示されること";
            // 
            // l008UserControl1
            // 
            this.l008UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l008UserControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l008UserControl1.Location = new System.Drawing.Point(65, 74);
            this.l008UserControl1.Name = "l008UserControl1";
            this.l008UserControl1.Size = new System.Drawing.Size(450, 40);
            this.l008UserControl1.TabIndex = 0;
            // 
            // L008Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l008UserControl1);
            this.Name = "L008Form";
            this.Text = "L008Form";
            this.Load += new System.EventHandler(this.L008Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private L008UserControl l008UserControl1;
        private System.Windows.Forms.Label label1;
    }
}