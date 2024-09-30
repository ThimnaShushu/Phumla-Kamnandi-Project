namespace Phumla_Kamanadi
{
    partial class BookingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.checkInDate = new System.Windows.Forms.DateTimePicker();
            this.checkOutDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numAdults = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numChildren = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timedBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.changeImage = new System.Windows.Forms.Button();
            this.chargePersonRadioButton = new System.Windows.Forms.RadioButton();
            this.chargeRoomRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.numRooms = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // checkInDate
            // 
            this.checkInDate.Location = new System.Drawing.Point(617, 175);
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.Size = new System.Drawing.Size(372, 26);
            this.checkInDate.TabIndex = 0;
            this.checkInDate.ValueChanged += new System.EventHandler(this.checkInDate_ValueChanged);
            // 
            // checkOutDate
            // 
            this.checkOutDate.Location = new System.Drawing.Point(617, 265);
            this.checkOutDate.Name = "checkOutDate";
            this.checkOutDate.Size = new System.Drawing.Size(381, 26);
            this.checkOutDate.TabIndex = 2;
            this.checkOutDate.ValueChanged += new System.EventHandler(this.checkOutDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Check-In Date";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(855, 649);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numAdults
            // 
            this.numAdults.Location = new System.Drawing.Point(799, 461);
            this.numAdults.Name = "numAdults";
            this.numAdults.Size = new System.Drawing.Size(133, 26);
            this.numAdults.TabIndex = 5;
            this.numAdults.ValueChanged += new System.EventHandler(this.numAdults_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1023, 81);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(479, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 58);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(417, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phumla Kamnandi Hotels ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Step 1: Book Your Stay With Us";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numChildren
            // 
            this.numChildren.Location = new System.Drawing.Point(799, 523);
            this.numChildren.Name = "numChildren";
            this.numChildren.Size = new System.Drawing.Size(133, 26);
            this.numChildren.TabIndex = 11;
            this.numChildren.ValueChanged += new System.EventHandler(this.numChildren_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Check-Out Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Children:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Adults:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(613, 649);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timedBox
            // 
            this.timedBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("timedBox.BackgroundImage")));
            this.timedBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.timedBox.Location = new System.Drawing.Point(1, 138);
            this.timedBox.Name = "timedBox";
            this.timedBox.Size = new System.Drawing.Size(576, 565);
            this.timedBox.TabIndex = 16;
            this.timedBox.TabStop = false;
            this.timedBox.Click += new System.EventHandler(this.timedBox_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(572, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 31);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Price:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(799, 579);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(132, 26);
            this.totalPriceTextBox.TabIndex = 19;
            this.totalPriceTextBox.TextChanged += new System.EventHandler(this.totalPriceTextBox_TextChanged);
            // 
            // changeImage
            // 
            this.changeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.changeImage.Location = new System.Drawing.Point(207, 129);
            this.changeImage.Name = "changeImage";
            this.changeImage.Size = new System.Drawing.Size(130, 38);
            this.changeImage.TabIndex = 20;
            this.changeImage.Text = "View Gallery";
            this.changeImage.UseVisualStyleBackColor = false;
            this.changeImage.Click += new System.EventHandler(this.changeImage_Click);
            // 
            // chargePersonRadioButton
            // 
            this.chargePersonRadioButton.AutoSize = true;
            this.chargePersonRadioButton.Location = new System.Drawing.Point(617, 350);
            this.chargePersonRadioButton.Name = "chargePersonRadioButton";
            this.chargePersonRadioButton.Size = new System.Drawing.Size(185, 24);
            this.chargePersonRadioButton.TabIndex = 21;
            this.chargePersonRadioButton.TabStop = true;
            this.chargePersonRadioButton.Text = "Charge Per Person";
            this.chargePersonRadioButton.UseVisualStyleBackColor = true;
            this.chargePersonRadioButton.CheckedChanged += new System.EventHandler(this.chargePersonRadioButton_CheckedChanged);
            // 
            // chargeRoomRadioButton
            // 
            this.chargeRoomRadioButton.AutoSize = true;
            this.chargeRoomRadioButton.Location = new System.Drawing.Point(841, 350);
            this.chargeRoomRadioButton.Name = "chargeRoomRadioButton";
            this.chargeRoomRadioButton.Size = new System.Drawing.Size(176, 24);
            this.chargeRoomRadioButton.TabIndex = 22;
            this.chargeRoomRadioButton.TabStop = true;
            this.chargeRoomRadioButton.Text = "Charge Per Room";
            this.chargeRoomRadioButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(624, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Number of Rooms";
            // 
            // numRooms
            // 
            this.numRooms.Location = new System.Drawing.Point(799, 394);
            this.numRooms.Name = "numRooms";
            this.numRooms.Size = new System.Drawing.Size(133, 26);
            this.numRooms.TabIndex = 24;
            this.numRooms.ValueChanged += new System.EventHandler(this.numRooms_ValueChanged);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1058, 740);
            this.Controls.Add(this.numRooms);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chargeRoomRadioButton);
            this.Controls.Add(this.chargePersonRadioButton);
            this.Controls.Add(this.changeImage);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.timedBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numChildren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numAdults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkOutDate);
            this.Controls.Add(this.checkInDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker checkInDate;
        private System.Windows.Forms.DateTimePicker checkOutDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numAdults;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numChildren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox timedBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Button changeImage;
        private System.Windows.Forms.RadioButton chargePersonRadioButton;
        private System.Windows.Forms.RadioButton chargeRoomRadioButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numRooms;
    }
}