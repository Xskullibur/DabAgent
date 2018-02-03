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
    public partial class CustEdit : Form
    {
        public CustEdit()
        {
            InitializeComponent();
        }

      

        private void CustEdit_Load(object sender, EventArgs e)
        {
            customerTA.Fill(dabAgencyDataSet.CustomerTB);
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Customer custclass = new Customer();
            //custclass.NRIC = nRICTextBox.Text;
            
            //bool a = custclass.IsNRICValid();
            //if (a.Equals(true))
            //{
            //    this.customerTBBS.EndEdit();
            //    this.tam.UpdateAll(this.dabAgencyDataSet);
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid IC");
            //}
            //FIX THIS IDK HOW TO(KEEGAN)
            
        
           
        }
    }
}
