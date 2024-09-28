namespace PhumlaKamnandi.Presentation
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
            this.checkInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.adultsLabel = new System.Windows.Forms.Label();
            this.childrenLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.checkInDateLabel = new System.Windows.Forms.Label();
            this.checkOutDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkInDateTimePicker
            // 
            this.checkInDateTimePicker.Location = new System.Drawing.Point(116, 149);
            this.checkInDateTimePicker.Name = "checkInDateTimePicker";
            this.checkInDateTimePicker.Size = new System.Drawing.Size(246, 22);
            this.checkInDateTimePicker.TabIndex = 0;
            this.checkInDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkOutDateTimePicker
            // 
            this.checkOutDateTimePicker.Location = new System.Drawing.Point(485, 149);
            this.checkOutDateTimePicker.Name = "checkOutDateTimePicker";
            this.checkOutDateTimePicker.Size = new System.Drawing.Size(246, 22);
            this.checkOutDateTimePicker.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(709, 270);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(709, 222);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(100, 222);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(209, 494);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(160, 22);
            this.amountTextBox.TabIndex = 5;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(97, 497);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(106, 16);
            this.amountLabel.TabIndex = 6;
            this.amountLabel.Text = "Total Amount :";
            this.amountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // adultsLabel
            // 
            this.adultsLabel.AutoSize = true;
            this.adultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultsLabel.Location = new System.Drawing.Point(510, 222);
            this.adultsLabel.Name = "adultsLabel";
            this.adultsLabel.Size = new System.Drawing.Size(133, 16);
            this.adultsLabel.TabIndex = 7;
            this.adultsLabel.Text = "Number of Adults :";
            // 
            // childrenLabel
            // 
            this.childrenLabel.AutoSize = true;
            this.childrenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childrenLabel.Location = new System.Drawing.Point(510, 272);
            this.childrenLabel.Name = "childrenLabel";
            this.childrenLabel.Size = new System.Drawing.Size(147, 16);
            this.childrenLabel.TabIndex = 8;
            this.childrenLabel.Text = "Number of Children :";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(606, 482);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 44);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(794, 482);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 44);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // checkInDateLabel
            // 
            this.checkInDateLabel.AutoSize = true;
            this.checkInDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInDateLabel.Location = new System.Drawing.Point(113, 119);
            this.checkInDateLabel.Name = "checkInDateLabel";
            this.checkInDateLabel.Size = new System.Drawing.Size(110, 16);
            this.checkInDateLabel.TabIndex = 11;
            this.checkInDateLabel.Text = "Check-in date :";
            // 
            // checkOutDateLabel
            // 
            this.checkOutDateLabel.AutoSize = true;
            this.checkOutDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutDateLabel.Location = new System.Drawing.Point(482, 119);
            this.checkOutDateLabel.Name = "checkOutDateLabel";
            this.checkOutDateLabel.Size = new System.Drawing.Size(119, 16);
            this.checkOutDateLabel.TabIndex = 12;
            this.checkOutDateLabel.Text = "Check-out date :";
            // 
            // BookingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(969, 575);
            this.Controls.Add(this.checkOutDateLabel);
            this.Controls.Add(this.checkInDateLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.childrenLabel);
            this.Controls.Add(this.adultsLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkOutDateTimePicker);
            this.Controls.Add(this.checkInDateTimePicker);
            this.Name = "BookingForm";
            this.Text = "Booking Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker checkInDateTimePicker;
        private System.Windows.Forms.DateTimePicker checkOutDateTimePicker;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label adultsLabel;
        private System.Windows.Forms.Label childrenLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label checkInDateLabel;
        private System.Windows.Forms.Label checkOutDateLabel;
    }
}