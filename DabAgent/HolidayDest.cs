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
    public partial class HolidayDest : Form
    {
        public HolidayDest()
        {
            InitializeComponent();
        }

        private void holidayTBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsDest.EndEdit();
            this.tam.UpdateAll(this.ds);

        }

        private void HolidayDest_Load(object sender, EventArgs e)
        {
            taDest.Fill(ds.HolidayTB);

            holidayTBDataGridView.BorderStyle = BorderStyle.None;
            holidayTBDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            holidayTBDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            holidayTBDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            holidayTBDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            holidayTBDataGridView.BackgroundColor = Color.White;

            holidayTBDataGridView.EnableHeadersVisualStyles = false;
            holidayTBDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            holidayTBDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            holidayTBDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditDest editDest = new EditDest();
            editDest.ShowDialog();
            taDest.Fill(ds.HolidayTB);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            bsDest.RemoveCurrent();
            taDest.Update(ds.HolidayTB);
            MessageBox.Show("Record Removed!");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddDest addDest = new AddDest();
            addDest.ShowDialog();
            taDest.Fill(ds.HolidayTB);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (taDest.FillBySearchCity(ds.HolidayTB, SearchTxt.Text) != 0)
            {
                taDest.FillBySearchCity(ds.HolidayTB, SearchTxt.Text); 
            }
            else
            {
                MessageBox.Show("No Records of (" + SearchTxt.Text + ") Not Found!");
            }
        }

        private void AllBtn_Click(object sender, EventArgs e)
        {
            taDest.Fill(ds.HolidayTB);
        }

        private void holidayTBDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in holidayTBDataGridView.SelectedRows)
            {
                EditDest editDest = new EditDest();
                editDest.id = row.Cells[0].Value.ToString();
                editDest.ShowDialog();
                taDest.Fill(ds.HolidayTB);
            }
        }
    }
}
