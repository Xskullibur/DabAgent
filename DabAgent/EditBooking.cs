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
    public partial class EditBooking : Form
    {
        public string id;

        public EditBooking()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            TitleLbl.Text = "Editing Booking ID: " + id;

            travelDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            travelDateDateTimePicker.CustomFormat = "dd MMMM yyyy";

            if (string.IsNullOrEmpty(id))
            {
                if (taBooking.Fill(ds.BookingTB) != 0)
                {
                    taBooking.Fill(ds.BookingTB);  
                }
                else
                {
                    MessageBox.Show("No Records Found!");
                }
            }
            else
            {
                taBooking.FillBySearchID(ds.BookingTB, Convert.ToInt32(id));
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bsBooking.EndEdit();
            try
            {
                taBooking.Update(ds.BookingTB);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Please Ensure all Fields are Filled...");
            }

            MessageBox.Show("Successfully Saved Changes!");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bookingTBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bsBooking.EndEdit();
            taBooking.Update(ds.BookingTB);
            MessageBox.Show("Successfully Saved Changes!");
        }
    }
}
