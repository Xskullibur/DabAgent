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
    public partial class EditDest : Form
    {
        public string id;

        public EditDest()
        {
            InitializeComponent();
        }

        private void holidayTBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bsDest.EndEdit();
            tam.UpdateAll(ds);
            MessageBox.Show("Successfully Saved Changes!");
        }

        private void EditDest_Load(object sender, EventArgs e)
        {
            TitleLbl.Text = "Editing Holiday Destination ID: " + id;
            if (string.IsNullOrEmpty(id))
            {
                if (taDest.Fill(ds.HolidayTB) != 0)
                {
                    taDest.Fill(ds.HolidayTB); 
                }
                else
                {
                    MessageBox.Show("No Records Found!");
                    this.Close();
                }
            }
            else
            {
                taDest.FillByID(ds.HolidayTB, id);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bsDest.EndEdit();
            try
            {
                taDest.Update(ds.HolidayTB);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Please Ensure all Fields are Filled...");
            }

            MessageBox.Show("Successfully Saved Changes!");
        }
    }
}
