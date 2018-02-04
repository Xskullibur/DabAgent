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

        private void bookingTBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsBooking.EndEdit();
            this.tam.UpdateAll(this.ds);

        }

        private void bookingTBBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            bsBooking.EndEdit();
            taBooking.Update(ds.BookingTB);
            MessageBox.Show("Successfully Saved Changes!");
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            travelDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            travelDateDateTimePicker.CustomFormat = "dd MMMM yyyy";

            if (string.IsNullOrEmpty(id))
            {
                taBooking.Fill(ds.BookingTB); 
            }
            else
            {
                taBooking.FillBySearchID(ds.BookingTB, Convert.ToInt32(id));
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bsBooking.EndEdit();
            taBooking.Update(ds.BookingTB);

            MessageBox.Show("Successfully Saved Changes!");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
