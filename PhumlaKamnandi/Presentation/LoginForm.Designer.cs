namespace PhumlaKamnandi.Presentation
{
    partial class LoginForm
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
            this.emplyeeIdLabel = new System.Windows.Forms.Label();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.noAccountLabel = new System.Windows.Forms.Label();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emplyeeIdLabel
            // 
            this.emplyeeIdLabel.AutoSize = true;
            this.emplyeeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplyeeIdLabel.Location = new System.Drawing.Point(406, 191);
            this.emplyeeIdLabel.Name = "emplyeeIdLabel";
            this.emplyeeIdLabel.Size = new System.Drawing.Size(160, 15);
            this.emplyeeIdLabel.TabIndex = 0;
            this.emplyeeIdLabel.Text = "Enter your employee ID:";
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Location = new System.Drawing.Point(405, 221);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(362, 20);
            this.employeeIdTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(405, 285);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(362, 22);
            this.passwordTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(402, 256);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(141, 15);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Enter your password:";
            this.passwordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Chartreuse;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(518, 362);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(105, 39);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "LogIn";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(594, 414);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(81, 27);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "SignUp";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(794, 444);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 32);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // noAccountLabel
            // 
            this.noAccountLabel.AutoSize = true;
            this.noAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noAccountLabel.Location = new System.Drawing.Point(415, 419);
            this.noAccountLabel.Name = "noAccountLabel";
            this.noAccountLabel.Size = new System.Drawing.Size(151, 15);
            this.noAccountLabel.TabIndex = 8;
            this.noAccountLabel.Text = "don\'t have a account ?";
            this.noAccountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCheckBox.Location = new System.Drawing.Point(405, 322);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(111, 19);
            this.passwordCheckBox.TabIndex = 9;
            this.passwordCheckBox.Text = "show password";
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            this.passwordCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PhumlaKamnandi.Properties.Resources._517917_200;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(518, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 87);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(902, 506);
            this.Controls.Add(this.passwordCheckBox);
            this.Controls.Add(this.noAccountLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(this.emplyeeIdLabel);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emplyeeIdLabel;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label noAccountLabel;
        private System.Windows.Forms.CheckBox passwordCheckBox;
    }
}