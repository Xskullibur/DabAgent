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
    public partial class AddBooking : Form
    {
        public static double CalcDistance(double latA, double lngA, double latB, double lngB)
        {
            // This method is adapted from Andrew Hedges' JavaScript code
            // http://andrew.hedges.name/experiments/haversine/
            if (latA == latB && lngA == lngB) return 0;
            double r = 6373.0; // earth radius
            double lat1 = latA * Math.PI / 180;
            double lng1 = lngA * Math.PI / 180;
            double lat2 = latB * Math.PI / 180;
            double lng2 = lngB * Math.PI / 180;
            double dlat = lat2 - lat1;
            double dlng = lng2 - lng1;
            double a = Math.Pow(Math.Sin(dlat / 2), 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Pow(Math.Sin(dlng / 2), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = c * r;

            // round to 3 significant digits
            double scale = Math.Pow(10, Math.Floor(Math.Log10(d)) + 1);
            return scale * Math.Round(d / scale, 3, MidpointRounding.AwayFromZero);
        }

        public static void GetGeoCoord(string place, ref double lat, ref double lng)
        {
            System.Xml.XmlDocument geoDoc = new System.Xml.XmlDocument();
            try
            {
                geoDoc.Load(string.Format(@"http://maps.googleapis.com/maps/api/geocode/xml?address={0}", place));
                lat = double.Parse(geoDoc.DocumentElement.SelectSingleNode(@"//location/lat").InnerText);
                lng = double.Parse(geoDoc.DocumentElement.SelectSingleNode(@"//location/lng").InnerText);
                System.Threading.Thread.Sleep(2500);  //Wait for 2.5 second
            }
            catch (NullReferenceException e)
            {
                throw new ArgumentException(place + " does not exist", "place");
            }
        }

        public AddBooking()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
        }

        private void CalBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            travelDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            travelDateDateTimePicker.CustomFormat = " ";
        }

        private void travelDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            travelDateDateTimePicker.CustomFormat = "dd MMMM yyyy";
        }
    }
}
