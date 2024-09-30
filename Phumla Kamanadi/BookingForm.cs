using Phumla_Kamnandi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamanadi
{
    public partial class BookingForm : Form
    {
        private List<string> imagePaths;
        private int currentImageIndex = 0;
        public BookingForm()
        {
            InitializeComponent();
            timedBox.SizeMode = PictureBoxSizeMode.Zoom;
            timedBox.BackColor = Color.LightGray;

            imagePaths = new List<string>
        {
            @"C:\Users\thimn\OneDrive - University of Cape Town\Desktop\INF2011S\Project\Phumla Kamnandi\premi.jpg",
            @"C:\Users\thimn\OneDrive - University of Cape Town\Desktop\INF2011S\Project\Phumla Kamnandi\roomCOuch.jpg",
            @"C:\Users\thimn\OneDrive - University of Cape Town\Desktop\INF2011S\Project\Phumla Kamnandi\roombed.jpg",
            @"C:\Users\thimn\OneDrive - University of Cape Town\Desktop\INF2011S\Project\Phumla Kamnandi\buffet.jpg",
            @"C:\Users\thimn\OneDrive - University of Cape Town\Desktop\INF2011S\Project\Phumla Kamnandi\pool2.jpg",
            @"C:\Users\thimn\OneDrive - University of Cape Town\Desktop\INF2011S\Project\Phumla Kamnandi\beach.jpg"
            // Add more image paths as needed
        };
            if (imagePaths.Count > 0)
            {
                timedBox.ImageLocation = imagePaths[0];
            }
        }

        private void ShowAll(bool value, Room.RoomTariffType roomType)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timedBox_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BookingForm_Load(object sender, EventArgs e)
        {

        }

        private void changeImage_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count > 0)
            {
                // Move to the next image, or loop back to the first one
                currentImageIndex = (currentImageIndex + 1) % imagePaths.Count;
                timedBox.ImageLocation = imagePaths[currentImageIndex];
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chargePersonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton chargePersonRb = sender as RadioButton;
            if (chargePersonRb != null)
            {
                if (!chargePersonRb.Checked)
                {
                    ShowAll(true, )
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
