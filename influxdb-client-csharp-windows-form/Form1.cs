using System;
using System.Windows.Forms;
using InfluxDB.Client;

namespace influxdb_client_csharp_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = InfluxDBClientFactory.Create("http://0.0.0.0:9999", "my-token".ToCharArray());
            var health = await client.HealthAsync();

            label2.Text = $"Health: {health.Status}, Version: {health.Version}";
            label2.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}