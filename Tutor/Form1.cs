using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using ProtoBuf;
using TransitRealtime;


namespace Tutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            WebRequest req = HttpWebRequest.Create("https://api.transport.nsw.gov.au/v1/gtfs/vehiclepos/buses");
            req.Headers.Add("Authorization", "apikey FFHj28bOesfr0rIAvS0STrxLbSKUHLi9I1TF");

            FeedMessage feed = Serializer.Deserialize<FeedMessage>(req.GetResponse().GetResponseStream());
            int i = 1;
            foreach (FeedEntity entity in feed.Entities)
            {
                if (entity.Vehicle.Position != null)
                {
                    string result = entity.Vehicle.Vehicle.Id.ToString() + entity.Vehicle.Position.Latitude.ToString() + entity.Vehicle.Position.Longitude.ToString();
                    tb_result.AppendText("RESULT" + i.ToString() + ": " + result + "\n");
                    TfnswVehicleDescriptor extra = entity.Vehicle.Vehicle.GetTfnswVehicleDescriptor();
                    Console.WriteLine(entity.Vehicle.Vehicle.Id + entity.Vehicle.Position.Latitude + "," + entity.Vehicle.Position.Longitude);
                    tb_result2.AppendText("VehicleModel" + i.ToString() + " = " + extra.VehicleModel + "\n");
                    System.Diagnostics.Debug.WriteLine("Test" + entity.Vehicle.Vehicle.Id + entity.Vehicle.Position.Latitude + "," + entity.Vehicle.Position.Longitude);
                }
                i++;

            }
        }
    }
}
