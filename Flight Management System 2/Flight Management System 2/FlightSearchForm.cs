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
    public partial class FlightSearchForm : Form
    {
        public FlightSearchForm()
        {
            InitializeComponent();
        }

        private void LoadSampleFlights()
        {
            // Sample data for testing - replace with database query later
            dgvFlights.Rows.Add(1, "AA101", "10:00 AM", "12:30 PM", "2h 30m", 45, 250);
            dgvFlights.Rows.Add(2, "UA202", "02:00 PM", "04:30 PM", "2h 30m", 30, 280);
            dgvFlights.Rows.Add(3, "DL303", "09:00 AM", "11:15 AM", "2h 15m", 52, 230);
            dgvFlights.Rows.Add(4, "SW404", "04:30 PM", "07:00 PM", "2h 30m", 38, 220);
            dgvFlights.Rows.Add(5, "BA505", "11:00 AM", "01:45 PM", "2h 45m", 25, 320);
        }

        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dgvFlights.Rows.Clear();

            // Validate Origin
            if (string.IsNullOrWhiteSpace(txtOrigin.Text) ||
                txtOrigin.Text == "Enter origin city" ||
                txtOrigin.ForeColor == Color.Gray)
            {
                MessageBox.Show("Please enter origin city.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOrigin.Focus();
                return;
            }

            // Validate Destination
            if (string.IsNullOrWhiteSpace(txtDestination.Text) ||
                txtDestination.Text == "Enter destination city" ||
                txtDestination.ForeColor == Color.Gray)
            {
                MessageBox.Show("Please enter destination city.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDestination.Focus();
                return;
            }

            // Check if same city
            if (txtOrigin.Text.Trim().ToLower() == txtDestination.Text.Trim().ToLower())
            {
                MessageBox.Show("Origin and destination cannot be the same.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show loading cursor
            Cursor = Cursors.WaitCursor;

            // Load flights
            LoadSampleFlights();

            Cursor = Cursors.Default;

            // Show result
            if (dgvFlights.Rows.Count == 0)
            {
                MessageBox.Show("No flights found for the selected route and date.",
                    "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Found {dgvFlights.Rows.Count} flight(s).",
                    "Search Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvFlights.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a flight first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected flight details
            var row = dgvFlights.SelectedRows[0];
            string flightId = row.Cells["ID"].Value.ToString();   //pupuntahan after iclick select flights
            string flightNumber = row.Cells["FlightNumber"].Value.ToString();
            string airline = row.Cells["Airline"].Value.ToString();
            string departure = row.Cells["Departure"].Value.ToString();
            string arrival = row.Cells["Arrival"].Value.ToString();
            string price = row.Cells["Price"].Value.ToString();

            // Show confirmation dialog
            DialogResult result = MessageBox.Show(
                $"You selected:\n\n" +
                $"Flight: {flightNumber}\n" +
                $"Departure: {departure}\n" +
                $"Arrival: {arrival}\n" +
                $"Price: ${price}\n\n" +
                $"Proceed to passenger details?",
                "Confirm Selection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // TODO: Open Passenger Details Form
                MessageBox.Show("Passenger Details Form - Coming Soon!", "Info");

                // Later when you create PassengerDetailsForm:
                // PassengerDetailsForm passengerForm = new PassengerDetailsForm(flightId);
                // passengerForm.FormClosed += (s, args) => this.Show();
                // passengerForm.Show();
                // this.Hide();
            }
        }
    }
}
