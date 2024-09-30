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
        private string CONNECTION_STRING = @"Data Source=";
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
        { string textToSearch = custNumTextBox.Text.ToString();
            conn.ConnectionString = CONNECTION_STRING;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Guest WHERE ID = '""'"
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {

        }

        private void custNumTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
