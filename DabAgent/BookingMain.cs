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
    public partial class BookingMain : Form
    {
        public BookingMain()
        {
            InitializeComponent();
        }

        private void bookingTBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsBooking.EndEdit();
            this.tam.UpdateAll(this.ds);

        }

        private void BookingMain_Load(object sender, EventArgs e)
        {
            taBooking.Fill(ds.BookingTB);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddBooking addBooking = new AddBooking();
            addBooking.ShowDialog();
            taBooking.Fill(ds.BookingTB);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            bsBooking.RemoveCurrent();
            taBooking.Update(ds.BookingTB);
            MessageBox.Show("Record Removed!");
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.ShowDialog();
        }
    }
}
