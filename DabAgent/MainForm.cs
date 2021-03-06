﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void AbtBtn_Click(object sender, EventArgs e)
        {
            Info about = new Info();
            about.ShowDialog();
        }

        private void HolidayBtn_Click(object sender, EventArgs e)
        {
            HolidayDest dest = new HolidayDest();
            dest.ShowDialog();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            CustForm cust = new CustForm();
            cust.ShowDialog();
        }

        private void btnViewBooking_Click(object sender, EventArgs e)
        {
            BookingMain book = new BookingMain();
            book.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Select();
        }
    }
}
