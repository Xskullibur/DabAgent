using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DabAgent
{
    public partial class BookingDisplay : Form
    {
        public string name;

        public BookingDisplay()
        {
            InitializeComponent();
        }

        private void BookingDisplay_Load(object sender, EventArgs e)
        {
            customerTBTableAdapter.Fill(ds.CustomerTB);
            NameLbl.Text = "Search Results of: " + name;

            if (taBooking.FillByNameBooking(ds.BookingTB, name) != 0)
            {
                taBooking.FillByNameBooking(ds.BookingTB, name);
                nameTextBox.Text = name;

                Booking booking = new Booking(Convert.ToInt32(bookingIDTextBox.Text), nRICTextBox.Text, Convert.ToDateTime(travelDateTextBox.Text), Convert.ToInt32(paxTextBox.Text), Convert.ToDouble(costPxTextBox.Text), departureTextBox.Text, arrivalTextBox.Text);
                TotalTxt.Text = "$ " + Math.Round(booking.TotalCost(), 2).ToString();
            }
            else
            {
                MessageBox.Show("Records of " + name + " Not Found!");
                this.Close();
            }
        }
    }
}
