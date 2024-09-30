namespace Phumla_Kamanadi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.searchLabel = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.customerEmail = new System.Windows.Forms.Label();
            this.customerPhone = new System.Windows.Forms.Label();
            this.customerAddress = new System.Windows.Forms.Label();
            this.custNameTextBox = new System.Windows.Forms.TextBox();
            this.custAddressTextBox = new System.Windows.Forms.TextBox();
            this.custPhoneTextBox = new System.Windows.Forms.TextBox();
            this.custEmailTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.customerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(150, 106);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(337, 32);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Confirm Customer Details";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(25, 54);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(124, 20);
            this.customerName.TabIndex = 6;
            this.customerName.Text = "Customer Name";
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.custEmailTextBox);
            this.customerGroupBox.Controls.Add(this.custPhoneTextBox);
            this.customerGroupBox.Controls.Add(this.custAddressTextBox);
            this.customerGroupBox.Controls.Add(this.custNameTextBox);
            this.customerGroupBox.Controls.Add(this.customerAddress);
            this.customerGroupBox.Controls.Add(this.customerPhone);
            this.customerGroupBox.Controls.Add(this.customerEmail);
            this.customerGroupBox.Controls.Add(this.customerName);
            this.customerGroupBox.Location = new System.Drawing.Point(156, 182);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(488, 260);
            this.customerGroupBox.TabIndex = 7;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customer Details";
            // 
            // customerEmail
            // 
            this.customerEmail.AutoSize = true;
            this.customerEmail.Location = new System.Drawing.Point(25, 190);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(121, 20);
            this.customerEmail.TabIndex = 7;
            this.customerEmail.Text = "Customer Email";
            // 
            // customerPhone
            // 
            this.customerPhone.AutoSize = true;
            this.customerPhone.Location = new System.Drawing.Point(25, 147);
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(128, 20);
            this.customerPhone.TabIndex = 8;
            this.customerPhone.Text = "Customer Phone";
            // 
            // customerAddress
            // 
            this.customerAddress.AutoSize = true;
            this.customerAddress.Location = new System.Drawing.Point(25, 99);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(141, 20);
            this.customerAddress.TabIndex = 9;
            this.customerAddress.Text = "Customer Address";
            // 
            // custNameTextBox
            // 
            this.custNameTextBox.Location = new System.Drawing.Point(191, 54);
            this.custNameTextBox.Name = "custNameTextBox";
            this.custNameTextBox.Size = new System.Drawing.Size(190, 26);
            this.custNameTextBox.TabIndex = 10;
            // 
            // custAddressTextBox
            // 
            this.custAddressTextBox.Location = new System.Drawing.Point(191, 99);
            this.custAddressTextBox.Name = "custAddressTextBox";
            this.custAddressTextBox.Size = new System.Drawing.Size(190, 26);
            this.custAddressTextBox.TabIndex = 11;
            // 
            // custPhoneTextBox
            // 
            this.custPhoneTextBox.Location = new System.Drawing.Point(191, 144);
            this.custPhoneTextBox.Name = "custPhoneTextBox";
            this.custPhoneTextBox.Size = new System.Drawing.Size(190, 26);
            this.custPhoneTextBox.TabIndex = 12;
            // 
            // custEmailTextBox
            // 
            this.custEmailTextBox.Location = new System.Drawing.Point(191, 187);
            this.custEmailTextBox.Name = "custEmailTextBox";
            this.custEmailTextBox.Size = new System.Drawing.Size(190, 26);
            this.custEmailTextBox.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-161, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1023, 81);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(317, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phumla Kamnandi Hotels ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(360, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 58);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(561, 478);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(117, 44);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(184, 478);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(138, 44);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customerGroupBox);
            this.Controls.Add(this.searchLabel);
            this.Name = "Form2";
            this.Text = "Search Customer";
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.Label customerAddress;
        private System.Windows.Forms.Label customerPhone;
        private System.Windows.Forms.Label customerEmail;
        private System.Windows.Forms.TextBox custEmailTextBox;
        private System.Windows.Forms.TextBox custPhoneTextBox;
        private System.Windows.Forms.TextBox custAddressTextBox;
        private System.Windows.Forms.TextBox custNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button backButton;
    }
}