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
    public partial class AddBooking : Form
    {
        public AddBooking()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bsBooking.EndEdit();
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("Please Fill in All Fields Before Adding...");
            }

            taBooking.Update(ds.BookingTB);
            MessageBox.Show("Record Added!");
            this.Close();
        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            travelDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            travelDateDateTimePicker.CustomFormat = " ";

            bsBooking.AddNew();
        }

        private void travelDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            travelDateDateTimePicker.CustomFormat = "dd MMMM yyyy";
        }
    }
}
