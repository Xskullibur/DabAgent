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
    public partial class CustomerInfo : Form
    {
        public string ic;

        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void customerTBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsCustomer.EndEdit();
            this.tam.UpdateAll(this.ds);

        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            if (taCustomer.FillBySearchNric(ds.CustomerTB, ic) != 0)
            {
                taCustomer.FillBySearchNric(ds.CustomerTB, ic); 
            }
            else
            {
                MessageBox.Show("No Records of " + ic + " Found!");
                this.Close();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
