namespace LoginForm
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.label1 = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.usrBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.repassBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(561, 274);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(117, 50);
            this.signupButton.TabIndex = 2;
            this.signupButton.Text = "Sign up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // usrBox
            // 
            this.usrBox.Location = new System.Drawing.Point(543, 127);
            this.usrBox.Name = "usrBox";
            this.usrBox.Size = new System.Drawing.Size(147, 27);
            this.usrBox.TabIndex = 4;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(543, 173);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(147, 27);
            this.passBox.TabIndex = 5;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // repassBox
            // 
            this.repassBox.Location = new System.Drawing.Point(543, 221);
            this.repassBox.Name = "repassBox";
            this.repassBox.Size = new System.Drawing.Size(147, 27);
            this.repassBox.TabIndex = 6;
            this.repassBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Re-type password";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(504, 352);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(230, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an account? Sign in.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(543, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "SIGN UP";
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.repassBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.usrBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.label1);
            this.Name = "SignupForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button signupButton;
        private Label label2;
        private TextBox usrBox;
        private TextBox passBox;
        private TextBox repassBox;
        private Label label4;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label label5;
    }
}