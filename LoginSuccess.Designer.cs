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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSuccess));
            this.exitButton = new System.Windows.Forms.Button();
            this.signoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(420, 309);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(149, 68);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // signoutButton
            // 
            this.signoutButton.Location = new System.Drawing.Point(197, 307);
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(165, 70);
            this.signoutButton.TabIndex = 1;
            this.signoutButton.Text = "Sign out";
            this.signoutButton.UseVisualStyleBackColor = true;
            this.signoutButton.Click += new System.EventHandler(this.signoutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LoginSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signoutButton);
            this.Controls.Add(this.exitButton);
            this.Name = "LoginSuccess";
            this.Text = "LoginSuccess";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button exitButton;
        private Button signoutButton;
        private PictureBox pictureBox1;
    }
}