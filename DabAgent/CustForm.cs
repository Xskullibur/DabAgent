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
            // TODO: This line of code loads data into the 'dabAgencyDataSet.CustomerTB' table. You can move, or remove it, as needed.
            this.customerTA.Fill(this.dabAgencyDS.CustomerTB);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            CustEdit custedit = new CustEdit();
            custedit.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CustEdit edit = new CustEdit();
            edit.ShowDialog();
        }
    }
}
