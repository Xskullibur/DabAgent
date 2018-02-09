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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text.Equals("pass"))
            {
                this.Close();
            }
            else if (!txtPassword.Text.Equals("pass"))
            {
                x++;
                if (x < 3)
                {
                    MessageBox.Show("Invaild Password\nPlease Try Again...!");
                }
                else
                {
                    MessageBox.Show("You Have Entered an Invalid Password Too Many Times!\nTerminating System...");
                    Application.Exit();
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
