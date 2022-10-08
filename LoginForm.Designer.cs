namespace LoginForm
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usrBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.signupLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // usrBox
            // 
            this.usrBox.Location = new System.Drawing.Point(452, 137);
            this.usrBox.Name = "usrBox";
            this.usrBox.Size = new System.Drawing.Size(151, 27);
            this.usrBox.TabIndex = 3;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(452, 198);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(151, 27);
            this.passBox.TabIndex = 4;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(471, 267);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(94, 29);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signupLabel
            // 
            this.signupLabel.AutoSize = true;
            this.signupLabel.Location = new System.Drawing.Point(404, 319);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(221, 20);
            this.signupLabel.TabIndex = 6;
            this.signupLabel.TabStop = true;
            this.signupLabel.Text = "Don\'t have an account? Sign up!";
            this.signupLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(471, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sign in";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signupLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.usrBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usrBox;
        private TextBox passBox;
        private Button loginButton;
        private LinkLabel signupLabel;
        private PictureBox pictureBox1;
        private Label label4;
    }
}