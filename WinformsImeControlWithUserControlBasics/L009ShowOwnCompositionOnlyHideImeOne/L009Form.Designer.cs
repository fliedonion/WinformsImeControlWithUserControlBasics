namespace WinformsImeControlWithUserControlBasics.L009ShowOwnCompositionOnlyHideImeOne {
    partial class L009Form {
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
            this.l009UserControl1 = new WinformsImeControlWithUserControlBasics.L009ShowOwnCompositionOnlyHideImeOne.L009UserControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "独自コンポジションの描画なし";
            // 
            // l009UserControl1
            // 
            this.l009UserControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l009UserControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l009UserControl1.Location = new System.Drawing.Point(65, 74);
            this.l009UserControl1.Name = "l009UserControl1";
            this.l009UserControl1.Size = new System.Drawing.Size(450, 40);
            this.l009UserControl1.TabIndex = 0;
            // 
            // L009Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l009UserControl1);
            this.Name = "L009Form";
            this.Text = "L009Form";
            this.Load += new System.EventHandler(this.L009Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private L009UserControl l009UserControl1;
        private System.Windows.Forms.Label label1;
    }
}