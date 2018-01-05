using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COD02
{
    public partial class detailForm : Form
    {
        //TODO: Previous, Next button

        public detailForm(Form1.Station stn)
        {
            InitializeComponent();

            numBox.Text = stn.StationId;
            staNumBox.Text = stn.StationNo;
            nameBox.Text = stn.StationName;
            latBox.Text = stn.StationLat;
            lonBox.Text = stn.StationLng;
            addrTxt.Text = stn.StationAddress;
        }

        private void mapBtn_Click(object sender, EventArgs e)
        {
            string url = string.Format("https://www.google.com/maps/place/{0},{1}",latBox.Text,lonBox.Text);
            System.Diagnostics.Process.Start(url);
        }
    }
}
