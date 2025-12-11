using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Management_System_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightSearchForm flightSearchForm = new FlightSearchForm();
            flightSearchForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View My Bookings - Coming Soon!", "Info");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Profile - Coming Soon!", "Info");
        }
    }
}
