namespace WinformsImeControlWithUserControlBasics.L007HideCompositionWindow {
    partial class L007Form {
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
            this.l007UserControl1 = new WinformsImeControlWithUserControlBasics.L007HideCompositionWindow.L007UserControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "変換中テキストが表示される事の確認";
            // 
            // l007UserControl1
            // 
            this.l007UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l007UserControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l007UserControl1.Location = new System.Drawing.Point(53, 79);
            this.l007UserControl1.Name = "l007UserControl1";
            this.l007UserControl1.Size = new System.Drawing.Size(450, 40);
            this.l007UserControl1.TabIndex = 0;
            // 
            // L007Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l007UserControl1);
            this.Name = "L007Form";
            this.Text = "L007Form";
            this.Load += new System.EventHandler(this.L007Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private L007UserControl l007UserControl1;
        private System.Windows.Forms.Label label1;
    }
}