namespace WinformsImeControlWithUserControlBasics.L008DisplayYourOwnCandidateWindow {
    partial class CandidateWindowForm {
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
            this.candidateListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // candidateListBox
            // 
            this.candidateListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.candidateListBox.FormattingEnabled = true;
            this.candidateListBox.ItemHeight = 18;
            this.candidateListBox.Location = new System.Drawing.Point(6, 6);
            this.candidateListBox.Name = "candidateListBox";
            this.candidateListBox.Size = new System.Drawing.Size(269, 346);
            this.candidateListBox.TabIndex = 0;
            // 
            // CandidateWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(278, 363);
            this.Controls.Add(this.candidateListBox);
            this.Name = "CandidateWindowForm";
            this.Text = "CandidateWindowForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox candidateListBox;
    }
}