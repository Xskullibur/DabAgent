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
    public partial class CustAdd : Form
    {
        public CustAdd()
        {
            InitializeComponent();
        }

        private void customerTBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBS.EndEdit();
            this.tam.UpdateAll(this.dabAgencyDS);

        }

        private void CustAdd_Load(object sender, EventArgs e)
        {
            date_of_BirthDateTimePicker.Format = DateTimePickerFormat.Custom;
            date_of_BirthDateTimePicker.CustomFormat = "dd MMMM yyyy";

            customerBS.AddNew();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.NRIC = nRICTextBox.Text;
            if (cust.IsNRICValid())
            {
                try
                {
                    customerBS.EndEdit();
                    try
                    {
                        customerTA.Update(dabAgencyDS.CustomerTB);
                        MessageBox.Show("Customer Added!");
                        this.Close();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Customer Already Exist!");
                    }
                }
                catch (NoNullAllowedException)
                {
                    MessageBox.Show("Please Ensure All Fields Are Filled!");
                }
            }
            else
            {
                MessageBox.Show("NRIC Invalid!");
            }
            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
