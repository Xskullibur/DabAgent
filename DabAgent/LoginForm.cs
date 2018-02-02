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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        int x = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.Equals("pass"))
            {
                this.Close();
            }
            else if(!txtPassword.Text.Equals("pass"))
            {
                x++;
                    if(x==3)
                {
                    Application.Exit();
                }
                MessageBox.Show("Wrong Password!");
            }
        }
    }
}
