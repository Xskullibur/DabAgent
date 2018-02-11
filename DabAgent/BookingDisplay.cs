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
        public string ic;

        public BookingDisplay()
        {
            InitializeComponent();
        }

        private void bookingTBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bsBooking.EndEdit();
            tam.UpdateAll(ds);
        }

        private void BookingDisplay_Load(object sender, EventArgs e)
        {
            taCusomter.Fill(ds.CustomerTB);
            NameLbl.Text = "Search Results of: " + ic;

            if (taBooking.FillBySearchNRIC(ds.BookingTB, ic) != 0)
            {
                taBooking.FillBySearchNRIC(ds.BookingTB, ic);
                taCusomter.FillBySearchNric(ds.CustomerTB, ic);

                Booking booking = new Booking(Convert.ToInt32(bookingIDTextBox.Text), nRICTextBox.Text, Convert.ToDateTime(travelDateTextBox.Text), Convert.ToInt32(paxTextBox.Text), Convert.ToDouble(costPxTextBox.Text), departureTextBox.Text, arrivalTextBox.Text);
                TotalTxt.Text = "$ " + Math.Round(booking.TotalCost(), 2).ToString();
            }
            else
            {
                MessageBox.Show("Records of " + ic + " Not Found!");
                this.Close();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
