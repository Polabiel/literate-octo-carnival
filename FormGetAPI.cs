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

        private async Task<CEP> GetDataAsync()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync("");
                string res = await response.Content.ReadAsStringAsync();

                CEP cep = JsonConvert.DeserializeObject<CEP>(res);

                return cep;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private async void btnRequest_Click(object sender, EventArgs e)
        {
            CEP data = await GetDataAsync();

            if (data != null)
            {
                txtResponseCep.Text = data.cep;
                field_logradouro.Text = data.logradouro;
                field_complemento.Text = data.complemento;
                field_bairro.Text = data.bairro;
                field_localidade.Text = data.localidade;
                field_uf.Text = data.uf;
                field_ibge.Text = data.ibge;
            }
        }
    }
}
