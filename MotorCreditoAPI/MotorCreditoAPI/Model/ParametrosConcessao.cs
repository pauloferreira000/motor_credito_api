using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorCreditoAPI.Model
{
    public class ParametrosConcessao
    {

        public int TaxaCredDireto { get; set; }
        public int TaxaCredConsignado { get; set; }
        public int TaxaCredPessoaJuridica { get; set; }
        public int TaxaCredPessoaFisica { get; set; }
        public int TaxaCredImobiliario { get; set; }
        public int ValorMaxCredito { get; set; }
        public int QtdMinParcela { get; set; }
        public int QtdMaxParcela { get; set; }
        public int ValMinPessoaJuridica { get; set; }
        public int MinDiasPrimeiroVencimento { get; set; }
        public int MaxDiasPrimeiroVencimento { get; set; }
        public DateTime DataAtual { get; set; }
        public Dictionary<int, string> TiposCredito { get; set; }

        public ParametrosConcessao()
        {
            TiposCredito = new Dictionary<int, string>()
            {
                { 1, "Credito direto"},
                { 2, "Credito consignado"},
                { 3, "Credito pessoa juridica"},
                { 4, "Credito pessoa fisica"},
                { 5, "Credito imobiliario"}
            };

            TaxaCredDireto = 2;
            TaxaCredConsignado = 1;
            TaxaCredPessoaJuridica = 5;
            TaxaCredPessoaFisica = 3;
            TaxaCredImobiliario = 9;
            ValorMaxCredito = 1000000;
            QtdMinParcela = 5;
            QtdMaxParcela = 72;
            ValMinPessoaJuridica = 15000;
            MinDiasPrimeiroVencimento = 15;
            MaxDiasPrimeiroVencimento = 40;
        }
    }
}
