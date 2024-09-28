using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PhumlaKamnandi.Presentation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\\\\technet.wf.uct.ac.za\\profiledata$\\MPPLIY002\\Documents\\PhumlaKamnandi\\PhumlaKamnandi\\PhumlaKamnandiDatabase.mdf;Integrated Security=True");
            conn.Open();
            string query = "SELECT COUNT(*) FROM Employee    WHERE  EmployeeID = @EmployeeID AND Password= @password ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeIdTextBox.Text);  // replace the @EmployeeID parameter with what is in the employeeId textbox
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text); // replace the @password parameter with what is in the password textbox
            int count= (int)cmd.ExecuteScalar();  //executing query
            
            conn.Close();

            if (count>0)  //if there is a row in the table that meets our query
            {
              MessageBox.Show("login success", "info",MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
            else
            {
                MessageBox.Show("error in login");

            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();  //close the form
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
           // passwordTextBox.UseSystemPasswordChar = !passwordCheckBox.Checked;
            passwordTextBox.PasswordChar = passwordCheckBox.Checked?'\0':'*';  //if the passworkCheckBox is not checked the each chatacter in the passwordTextBox should be replaced by a * 
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();  //close the form
        }
    }
}
