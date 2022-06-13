using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorCreditoAPI.Model
{
    public class AnaliseCreditoDto
    {
        public string Tipo { get; set; }
        public decimal ValorCreditoSolicitado { get; set; }
        public int QtdParcelas { get; set; }
        public string TaxaJuros { get; set; }
        public decimal ValorJuros { get; set; }
        public decimal ValorTotalComJuros { get; set; }
        public DateTime DataPrimeiroVenc { get; set; }
        public string Status { get; set; }
        public List<string> Impedimentos { get; set; }






    }
}
