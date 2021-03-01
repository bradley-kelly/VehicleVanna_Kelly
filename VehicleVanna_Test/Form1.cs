using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace VehicleVanna_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public async void SubmitBtn_Click(object sender, EventArgs e)
        {
            Vehicle.Vehicles item = new Vehicle.Vehicles(
                CarMakeBox.Text,
                CarModelBox.Text,
                YearBox.Text,
                (Int32)ListPriceBox.Value,
                VehicleTypeBox.SelectedIndex.ToString(),
                FirstNameBox.Text,
                LastNameBox.Text,
                EmailBox.Text);
            string url = "https://vehiclevannakelly.azurewebsites.net/api/Function1?code=VIMBL/nUJSPK8ao2nu8xMswJtkQrs4f6yETmkevI6BzjzZHM24sBfw==";
            var client = new HttpClient();
            HttpResponseMessage response = await client.PostAsJsonAsync(url, item);
            this.Hide();
            MessageBox.Show(response.Content.ReadAsStringAsync().Result.ToString());
            this.Show();
        }
    }
}