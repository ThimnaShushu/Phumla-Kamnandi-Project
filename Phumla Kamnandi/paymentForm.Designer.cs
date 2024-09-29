namespace Phumla_Kamnandi
{
    partial class paymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentForm));
            this.cardPaymentLabel = new System.Windows.Forms.Label();
            this.initialsLabel = new System.Windows.Forms.Label();
            this.cardHolderSurnameLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.expDateLabel = new System.Windows.Forms.Label();
            this.paymentButton = new System.Windows.Forms.Button();
            this.cancelPaymentButton = new System.Windows.Forms.Button();
            this.cvcLabel = new System.Windows.Forms.Label();
            this.initialsTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.expDateTextBox = new System.Windows.Forms.TextBox();
            this.cvcTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.homePic = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // cardPaymentLabel
            // 
            this.cardPaymentLabel.AutoSize = true;
            this.cardPaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardPaymentLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cardPaymentLabel.Location = new System.Drawing.Point(530, 82);
            this.cardPaymentLabel.Name = "cardPaymentLabel";
            this.cardPaymentLabel.Size = new System.Drawing.Size(212, 31);
            this.cardPaymentLabel.TabIndex = 0;
            this.cardPaymentLabel.Text = "Payment Details";
            this.cardPaymentLabel.Click += new System.EventHandler(this.cardPaymentLabel_Click);
            // 
            // initialsLabel
            // 
            this.initialsLabel.AutoSize = true;
            this.initialsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialsLabel.Location = new System.Drawing.Point(273, 174);
            this.initialsLabel.Name = "initialsLabel";
            this.initialsLabel.Size = new System.Drawing.Size(178, 25);
            this.initialsLabel.TabIndex = 1;
            this.initialsLabel.Text = "Card holder initials:";
            // 
            // cardHolderSurnameLabel
            // 
            this.cardHolderSurnameLabel.AutoSize = true;
            this.cardHolderSurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardHolderSurnameLabel.Location = new System.Drawing.Point(273, 221);
            this.cardHolderSurnameLabel.Name = "cardHolderSurnameLabel";
            this.cardHolderSurnameLabel.Size = new System.Drawing.Size(98, 25);
            this.cardHolderSurnameLabel.TabIndex = 2;
            this.cardHolderSurnameLabel.Text = "Surname:";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberLabel.Location = new System.Drawing.Point(273, 259);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(135, 25);
            this.cardNumberLabel.TabIndex = 3;
            this.cardNumberLabel.Text = "Card Number:";
            // 
            // expDateLabel
            // 
            this.expDateLabel.AutoSize = true;
            this.expDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDateLabel.Location = new System.Drawing.Point(273, 295);
            this.expDateLabel.Name = "expDateLabel";
            this.expDateLabel.Size = new System.Drawing.Size(175, 25);
            this.expDateLabel.TabIndex = 4;
            this.expDateLabel.Text = "Exp Date (mm/yy):";
            // 
            // paymentButton
            // 
            this.paymentButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.paymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paymentButton.Location = new System.Drawing.Point(665, 378);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(130, 39);
            this.paymentButton.TabIndex = 5;
            this.paymentButton.Text = "Pay";
            this.paymentButton.UseVisualStyleBackColor = false;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // cancelPaymentButton
            // 
            this.cancelPaymentButton.BackColor = System.Drawing.Color.IndianRed;
            this.cancelPaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelPaymentButton.Location = new System.Drawing.Point(853, 378);
            this.cancelPaymentButton.Name = "cancelPaymentButton";
            this.cancelPaymentButton.Size = new System.Drawing.Size(124, 39);
            this.cancelPaymentButton.TabIndex = 6;
            this.cancelPaymentButton.Text = "Cancel";
            this.cancelPaymentButton.UseVisualStyleBackColor = false;
            this.cancelPaymentButton.Click += new System.EventHandler(this.cancelPaymentButton_Click);
            // 
            // cvcLabel
            // 
            this.cvcLabel.AutoSize = true;
            this.cvcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvcLabel.Location = new System.Drawing.Point(575, 298);
            this.cvcLabel.Name = "cvcLabel";
            this.cvcLabel.Size = new System.Drawing.Size(62, 25);
            this.cvcLabel.TabIndex = 7;
            this.cvcLabel.Text = "CVC:";
            // 
            // initialsTextBox
            // 
            this.initialsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialsTextBox.Location = new System.Drawing.Point(457, 174);
            this.initialsTextBox.Name = "initialsTextBox";
            this.initialsTextBox.Size = new System.Drawing.Size(100, 30);
            this.initialsTextBox.TabIndex = 8;
            this.initialsTextBox.TextChanged += new System.EventHandler(this.initialsTextBox_TextChanged);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTextBox.Location = new System.Drawing.Point(457, 216);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(380, 30);
            this.surnameTextBox.TabIndex = 9;
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberTextBox.Location = new System.Drawing.Point(457, 252);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(380, 30);
            this.cardNumberTextBox.TabIndex = 10;
            // 
            // expDateTextBox
            // 
            this.expDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDateTextBox.Location = new System.Drawing.Point(454, 295);
            this.expDateTextBox.Name = "expDateTextBox";
            this.expDateTextBox.Size = new System.Drawing.Size(100, 30);
            this.expDateTextBox.TabIndex = 11;
            this.expDateTextBox.TextChanged += new System.EventHandler(this.expDateTextBox_TextChanged);
            // 
            // cvcTextBox
            // 
            this.cvcTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.cvcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvcTextBox.Location = new System.Drawing.Point(654, 295);
            this.cvcTextBox.Name = "cvcTextBox";
            this.cvcTextBox.Size = new System.Drawing.Size(118, 30);
            this.cvcTextBox.TabIndex = 12;
            this.cvcTextBox.TextChanged += new System.EventHandler(this.cvcTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(598, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLabel.Location = new System.Drawing.Point(273, 134);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(66, 25);
            this.emailAddressLabel.TabIndex = 14;
            this.emailAddressLabel.Text = "Email:";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressTextBox.Location = new System.Drawing.Point(457, 131);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(380, 30);
            this.emailAddressTextBox.TabIndex = 15;
            this.emailAddressTextBox.TextChanged += new System.EventHandler(this.emailAddressTextBox_TextChanged);
            // 
            // homePic
            // 
            this.homePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homePic.Image = ((System.Drawing.Image)(resources.GetObject("homePic.Image")));
            this.homePic.Location = new System.Drawing.Point(0, 1);
            this.homePic.Name = "homePic";
            this.homePic.Size = new System.Drawing.Size(187, 135);
            this.homePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homePic.TabIndex = 16;
            this.homePic.TabStop = false;
            this.homePic.Click += new System.EventHandler(this.homePic_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(496, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(654, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(770, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // paymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1122, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.homePic);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cvcTextBox);
            this.Controls.Add(this.expDateTextBox);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.initialsTextBox);
            this.Controls.Add(this.cvcLabel);
            this.Controls.Add(this.cancelPaymentButton);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.expDateLabel);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.cardHolderSurnameLabel);
            this.Controls.Add(this.initialsLabel);
            this.Controls.Add(this.cardPaymentLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "paymentForm";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cardPaymentLabel;
        private System.Windows.Forms.Label initialsLabel;
        private System.Windows.Forms.Label cardHolderSurnameLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.Label expDateLabel;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Button cancelPaymentButton;
        private System.Windows.Forms.Label cvcLabel;
        private System.Windows.Forms.TextBox initialsTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.TextBox expDateTextBox;
        private System.Windows.Forms.TextBox cvcTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.PictureBox homePic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}