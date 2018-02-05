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
            customerBS.AddNew();

        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            customerBS.EndEdit();
            customerTA.Update(dabAgencyDS.CustomerTB);
        }
    }
}
