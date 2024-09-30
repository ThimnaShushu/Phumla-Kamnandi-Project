namespace Phumla_Kamanadi
{
    partial class customerSeach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerSeach));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.customerName = new System.Windows.Forms.Label();
            this.custSearchButton = new System.Windows.Forms.Button();
            this.createNewButton = new System.Windows.Forms.Button();
            this.custNumTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.customerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-82, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1023, 81);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(284, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 58);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(234, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phumla Kamnandi Hotels ";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(135, 108);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(421, 32);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "Please Enter Customer Number;";
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.custNumTextBox);
            this.customerGroupBox.Controls.Add(this.createNewButton);
            this.customerGroupBox.Controls.Add(this.custSearchButton);
            this.customerGroupBox.Controls.Add(this.customerName);
            this.customerGroupBox.Location = new System.Drawing.Point(109, 174);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(488, 154);
            this.customerGroupBox.TabIndex = 13;
            this.customerGroupBox.TabStop = false;
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(25, 54);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(0, 20);
            this.customerName.TabIndex = 6;
            // 
            // custSearchButton
            // 
            this.custSearchButton.Location = new System.Drawing.Point(29, 99);
            this.custSearchButton.Name = "custSearchButton";
            this.custSearchButton.Size = new System.Drawing.Size(150, 38);
            this.custSearchButton.TabIndex = 11;
            this.custSearchButton.Text = "Search Customer";
            this.custSearchButton.UseVisualStyleBackColor = true;
            this.custSearchButton.Click += new System.EventHandler(this.custSearchButton_Click);
            // 
            // createNewButton
            // 
            this.createNewButton.Location = new System.Drawing.Point(286, 99);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(177, 38);
            this.createNewButton.TabIndex = 12;
            this.createNewButton.Text = "Create New Customer";
            this.createNewButton.UseVisualStyleBackColor = true;
            this.createNewButton.Click += new System.EventHandler(this.createNewButton_Click);
            // 
            // custNumTextBox
            // 
            this.custNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNumTextBox.Location = new System.Drawing.Point(32, 35);
            this.custNumTextBox.Name = "custNumTextBox";
            this.custNumTextBox.Size = new System.Drawing.Size(363, 39);
            this.custNumTextBox.TabIndex = 13;
            this.custNumTextBox.TextChanged += new System.EventHandler(this.custNumTextBox_TextChanged);
            // 
            // customerSeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 403);
            this.Controls.Add(this.customerGroupBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "customerSeach";
            this.Text = "customerSeach";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Button custSearchButton;
        private System.Windows.Forms.TextBox custNumTextBox;
    }
}