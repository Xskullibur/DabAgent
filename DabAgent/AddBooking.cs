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
    public partial class AddBooking : Form
    {
        public AddBooking()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bsBooking.EndEdit();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Customer NRIC Does Not Exist!");
            }
            try
            {
                taBooking.Update(ds.BookingTB);
                MessageBox.Show("Record Added!");
                this.Close();
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("Please Fill in All Fields Before Adding...");
            }
        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            travelDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            travelDateDateTimePicker.CustomFormat = " ";

            bookingDateComboBox.Items.Add(DateTime.Today);

            bsBooking.AddNew();
            bsBooking.MoveLast();
        }

        private void travelDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            travelDateDateTimePicker.CustomFormat = "dd MMMM yyyy";
        }
    }
}
