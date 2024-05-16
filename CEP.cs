using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormGetAPI
{
    public class CEP
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }

        public override string ToString()
        {
            return $"CEP: {cep}\nLogradouro: {logradouro}\nComplemento: {complemento}\nBairro: {bairro}\nLocalidade: {localidade}\nUF: {uf}\nIBGE: {ibge}";
        }
    }
}
