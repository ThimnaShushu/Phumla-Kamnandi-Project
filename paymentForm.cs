using PhumlaKamnandiHotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Phumla_Kamnandi
{
    public partial class paymentForm : Form
    {
        public paymentForm()
        {
            InitializeComponent();
        }

        private void cardPaymentLabel_Click(object sender, EventArgs e)
        {

        }

        private void paymentButton_Click(object sender, EventArgs e) { 
            
            // Validate inputs before proceeding
            if (ValidateInputs())
            {
                // If validation passes, continue with the logic
                MessageBox.Show("Payment successful\n Booking Confirmation sent to "+emailAddressTextBox.Text);

                
            }
            else
            {
                // Validation failed
            }
        }

        
            //MessageBox.Show("Payment successful\n Booking Confirmation sent to "+emailAddressTextBox.Text);
        

        private void cancelPaymentButton_Click(object sender, EventArgs e)
        {
            emailAddressTextBox.Clear();
            surnameTextBox.Clear();
            cardNumberTextBox.Clear();
            cvcTextBox.Clear();
            expDateTextBox.Clear();
            initialsTextBox.Clear();

        }

        private void homePic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go back to login Screee?");
        }

        private void cvcTextBox_TextChanged(object sender, EventArgs e)
        {
            // Hide the CVC
            cvcTextBox.PasswordChar = '*';

            
        }

        private bool ValidateInputs()
        {
            // Check if the username or password fields are empty
            if (string.IsNullOrWhiteSpace(emailAddressTextBox.Text))
            {
                MessageBox.Show("Email is missing!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Validation failed
            }
            if (string.IsNullOrWhiteSpace(initialsTextBox.Text))
            {
                MessageBox.Show("Missing initials !", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Validation failed
            }
            if (string.IsNullOrWhiteSpace(surnameTextBox.Text))
            {
                MessageBox.Show("Surname is missing!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Validation failed
            }
            
            if (string.IsNullOrWhiteSpace(cardNumberTextBox.Text))
            {
                MessageBox.Show("Card Number is missing!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Validation failed
            }
            if (string.IsNullOrWhiteSpace(expDateTextBox.Text))
            {
                MessageBox.Show("Exp date is missing!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Validation failed
            }
            // Check if the CVC field is empty or contains only white spaces
            if (string.IsNullOrWhiteSpace(cvcTextBox.Text))
            {
                MessageBox.Show("CVC is missing!", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Validation failed
            }

            // Check if the CVC length is not exactly 3 digits
            if (cvcTextBox.Text.Length != 3 || !cvcTextBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("CVC must be exactly 3 digits.", "Invalid CVC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Validation failed
            }
            // Check if the input length is not equal to 3
            if (cvcTextBox.Text.Length != 3)
            {
                // Display an error message if the length is not exactly 3
                MessageBox.Show("CVC must be exactly 3 digits.");
            }

            // If everything is okay
            return true;
        }

        
    }
}
