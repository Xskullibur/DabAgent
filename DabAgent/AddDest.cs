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
            bsDest.EndEdit();
            tam.UpdateAll(ds);
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            try
            {
                bsDest.EndEdit();
                taDest.Update(ds.HolidayTB);
                MessageBox.Show("Record Added!");
                this.Close();
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("Please Fill in All Fields Before Adding...");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Holiday Destination Already Exist!");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDest_Load(object sender, EventArgs e)
        {
            bsDest.AddNew();
            bsDest.MoveLast();
        }
    }
}
