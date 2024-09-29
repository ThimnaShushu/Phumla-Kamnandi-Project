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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
                MessageBox.Show("Payment successful!\nPayment Confirmation sent to "+emailAddressTextBox.Text);

                
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
            MessageBox.Show("Go back to login Screen");
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
            // Check if the input contains "@gmail.com"
            string email = emailAddressTextBox.Text.ToLower();

            if (!email.EndsWith("@gmail.com") || char.IsDigit(email[0]))
            {
                // Show a message box to alert the user
                MessageBox.Show("Please enter a valid Gmail address.",
                                "Invalid Email",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
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
            if (cardNumberTextBox.Text.Length != 12 || !cardNumberTextBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Card Number should be exactly 12 numbers.", "Invalid CVC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Validation failed
            }
            
            if (string.IsNullOrWhiteSpace(expDateTextBox.Text))
            {
                MessageBox.Show("Exp date is missing!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Validation failed
            }
            // Get the text from the expDateTextBox
            string input = expDateTextBox.Text;

            // Check if the input length is exactly 5 (mm/yy) and the third character is '/'
            if (input.Length == 5 && input[2] == '/')
            {
                // Split the input string into month and year parts
                string[] parts = input.Split('/');

                // Try to parse the month and year
                if (int.TryParse(parts[0], out int month) && int.TryParse(parts[1], out int year))
                {
                    // Check if the month is valid (1 to 12)
                    if (month >= 9 && month <= 12)
                    {
                        // Check if the year is greater than 24
                        if (year <24)
                        {

                            // Year is not greater than 24
                            MessageBox.Show("This card has expired!! \n Try another card.");
                            return false;
                        }
                    }
                    else
                    {
                        // INVALID MONTH
                        MessageBox.Show("This card has expired!! \n Try another card.");
                        return false;
                    }
                }
                else
                {
                    // Could not parse month or year
                    MessageBox.Show("Invalid Card: Use format (mm/yy)");
                    return false;
                }
            }
            else
            {
                // missing '/'
                MessageBox.Show("Invalid Card: Please enter the expiration date in the format mm/yy.");
                return false;
            }
            // Check if the CVC field is empty or contains only white spaces
            if (string.IsNullOrWhiteSpace(cvcTextBox.Text))
            {
                MessageBox.Show("CVC is missing!", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Validation failed
            }
            foreach (char c in cvcTextBox.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("CVC must contain only numbers!", "Invalid CVC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; // Validation failed
                }
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

        private void emailAddressTextBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void initialsTextBox_TextChanged(object sender, EventArgs e)
        {
            string initials = initialsTextBox.Text;

            // Check if the input contains any numeric characters
            if (initials.Any(char.IsDigit))
            {
                // Change the background color to indicate an error
                initialsTextBox.BackColor = Color.LightCoral;

                // Optionally show a message box
                MessageBox.Show("Initials cannot contain numbers. Please enter valid initials.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                // Reset background color when input is valid
                initialsTextBox.BackColor = Color.White;
            }
        }

        private void expDateTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
