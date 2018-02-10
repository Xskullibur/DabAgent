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
    public partial class AddDest : Form
    {
        public AddDest()
        {
            InitializeComponent();
        }

        private void holidayTBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsDest.EndEdit();
            this.tam.UpdateAll(this.ds);

        }

        private void AddDest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dabAgencyDataSet.HolidayTB' table. You can move, or remove it, as needed.
            this.taDest.Fill(this.ds.HolidayTB);

        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            try
            {
                bsDest.EndEdit();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Holiday ID Does Not Exist!");
            }
            try
            {
                taDest.Update(ds.HolidayTB);
                MessageBox.Show("Record Added!");
                this.Close();
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("Please Fill in All Fields Before Adding...");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
