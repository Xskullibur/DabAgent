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
    public partial class CustForm : Form
    {
        public CustForm()
        {
            InitializeComponent();
        }

        private void customerTBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBS.EndEdit();
            this.tam.UpdateAll(this.dabAgencyDS);

        }

        private void CustForm_Load(object sender, EventArgs e)
        {
            customerTA.Fill(dabAgencyDS.CustomerTB);
            date_of_BirthDateTimePicker.Format = DateTimePickerFormat.Custom;
            date_of_BirthDateTimePicker.CustomFormat = "ddMMMMyyyy";
        }
   

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer custclass = new Customer();
            custclass.NRIC = nRICTextBox.Text;

            if (custclass.IsNRICValid())
            {
                customerBS.EndEdit();
                customerTA.Update(dabAgencyDS.CustomerTB);
                MessageBox.Show("Updated Successfully!!!");
            }
            else
            {
                MessageBox.Show("Invalid NRIC\nPlease Try Again...");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustAdd add = new CustAdd();
            add.ShowDialog();
            customerTA.Fill(dabAgencyDS.CustomerTB);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            customerTA.FillBySearchNric(dabAgencyDS.CustomerTB, txtSearch.Text);
        }
    }
}
