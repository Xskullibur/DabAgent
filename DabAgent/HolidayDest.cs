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
            this.holidayTBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dabAgencyDataSet);

        }

        private void HolidayDest_Load(object sender, EventArgs e)
        {
            holidayTBTableAdapter.Fill(dabAgencyDataSet.HolidayTB);

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
    }
}
