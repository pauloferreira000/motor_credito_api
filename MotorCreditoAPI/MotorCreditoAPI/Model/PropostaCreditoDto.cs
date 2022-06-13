using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorCreditoAPI.Model
{
    public class PropostaCreditoDto
    {
        public int Tipo { get; set; }
        public decimal Valor { get; set; }
        public int QtdParcelas { get; set; }
        public DateTime DataPrimeiroVenc { get; set; }         
    }
}
