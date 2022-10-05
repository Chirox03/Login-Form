namespace LoginForm
{
    partial class LoginSuccess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logsucText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logsucText
            // 
            this.logsucText.AutoSize = true;
            this.logsucText.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.logsucText.Location = new System.Drawing.Point(187, 55);
            this.logsucText.Name = "logsucText";
            this.logsucText.Size = new System.Drawing.Size(317, 37);
            this.logsucText.TabIndex = 0;
            this.logsucText.Text = "Login Successful!";
            // 
            // LoginSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 152);
            this.Controls.Add(this.logsucText);
            this.Name = "LoginSuccess";
            this.Text = "LoginSuccess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label logsucText;
    }
}