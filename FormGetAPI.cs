using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGetAPI
{
    public partial class FormGetAPI : Form
    {
        public FormGetAPI()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            // Criar o RestClient

            // Setar o endPoint dele psrs a URI desejada

            // Fazer a chamada do método que executa o request

            // atualizar a tela com a resposta do usuário
        }
    }
}
