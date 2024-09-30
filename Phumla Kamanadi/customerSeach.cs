using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamanadi
{
    public partial class customerSeach : Form
    {
        private string CONNECTION_STRING = @"Data Source=YourServerName;Initial Catalog=YourDatabaseName;Integrated Security=True";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();
        public customerSeach()
        {
            InitializeComponent();
        }

        private void custNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void custSearchButton_Click(object sender, EventArgs e)
        {
            string guestId = custNumTextBox.Text.Trim();

            if (string.IsNullOrEmpty(guestId))
            {
                MessageBox.Show("Please enter a guest ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Guest WHERE ID = @GuestID", conn))
                    {
                        cmd.Parameters.AddWithValue("@GuestID", guestId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                DataRow row = dt.Rows[0];
                                string message = $"Guest Information:\n\n" +
                                                 $"ID: {row["ID"]}\n" +
                                                 $"Name: {row["Name"]}\n" +
                                                 $"Address: {row["Address"]}\n" +
                                                 $"Phone: {row["Phone"]}\n" +
                                                 $"Email: {row["Email"]}";

                                DialogResult result = MessageBox.Show(message, "Guest Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                if (result == DialogResult.Yes)
                                {
                                    // Navigate to the create new customer form
                                    CreateNewCustomerForm newCustomerForm = new CreateNewCustomerForm();
                                    newCustomerForm.Show();
                                    this.Hide(); // Optionally hide the current form
                                }
                            }
                            else
                            {
                                MessageBox.Show("No guest found with the given ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {

        }

        private void custNumTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
