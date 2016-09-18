namespace WinformsImeControlWithUserControlBasics.L004DisplayCompositionWindowInsideControl {
    partial class L004Form {
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
            this.l004UserControl1 = new WinformsImeControlWithUserControlBasics.L004DisplayCompositionWindowInsideControl.L004UserControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "入力中の文字がコントロール内に表示される\r\n(場所を決めなくてはならないことを明示するために少し右側に出しています)";
            // 
            // l004UserControl1
            // 
            this.l004UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l004UserControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l004UserControl1.Location = new System.Drawing.Point(50, 80);
            this.l004UserControl1.Name = "l004UserControl1";
            this.l004UserControl1.Size = new System.Drawing.Size(450, 40);
            this.l004UserControl1.TabIndex = 5;
            // 
            // L004Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 190);
            this.Controls.Add(this.l004UserControl1);
            this.Controls.Add(this.label1);
            this.Name = "L004Form";
            this.Text = "L004Form";
            this.Load += new System.EventHandler(this.L004Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private L004UserControl l004UserControl1;
    }
}