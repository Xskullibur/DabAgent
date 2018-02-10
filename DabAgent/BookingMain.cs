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
            Validate();
            bsBooking.EndEdit();
            tam.UpdateAll(ds);
        }

        private void BookingMain_Load(object sender, EventArgs e)
        {
            taBooking.Fill(ds.BookingTB);
        }

        private void bookingTBDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in bookingTBDataGridView.SelectedRows)
            {
                EditBooking editBooking = new EditBooking();
                editBooking.id = row.Cells[0].Value.ToString();
                editBooking.ShowDialog();
                taBooking.Fill(ds.BookingTB);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            BookingDisplay bookingDisplay = new BookingDisplay();
            bookingDisplay.ic = SearchTxt.Text;
            bookingDisplay.ShowDialog();
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
            EditBooking editForm = new EditBooking();
            editForm.ShowDialog();
            taBooking.Fill(ds.BookingTB);
        }

        
    }
}
