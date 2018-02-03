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
            

        }
   

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CustEdit edit = new CustEdit();
            edit.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustAdd add = new CustAdd();
            add.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            customerTA.FillBySearchNric(dabAgencyDS.CustomerTB, txtSearch.Text);
        }
    }
}
