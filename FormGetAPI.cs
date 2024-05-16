using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGetAPI
{
    public partial class FormGetAPI : Form
    {
        private HttpClient _client;

        public FormGetAPI()
        {
            InitializeComponent();
            _client = new HttpClient();
            string uri = txtURI.Text;
            _client.BaseAddress = new Uri(uri);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task<string> GetDataAsync()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync("");
                string res = await response.Content.ReadAsStringAsync();

                CEP cep = JsonConvert.DeserializeObject<CEP>(res);

                return cep.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private async void btnRequest_Click(object sender, EventArgs e)
        {
            string data = await GetDataAsync();

            txtResponseCep.Text = data;
        }
    }
}
