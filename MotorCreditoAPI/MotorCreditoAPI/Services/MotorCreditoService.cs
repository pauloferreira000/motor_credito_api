using MotorCreditoAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorCreditoAPI.Services
{
    public class MotorCreditoService : IMotorCreditoService
    {
        public AnaliseCreditoDto validarRegrasGeraisCredito(PropostaCreditoDto proposta)
        {
            try
            {
                var param = new ParametrosConcessao();
                var retorno = new AnaliseCreditoDto();
                retorno.Impedimentos = new List<string>();

                if (proposta.Valor > param.ValorMaxCredito)
                {
                    retorno.Status = "Recusado";
                    retorno.Impedimentos.Add("O valor desejado excede o valor máximo de crédito.");
                }

                if (proposta.QtdParcelas < param.QtdMinParcela || proposta.QtdParcelas > param.QtdMaxParcela)
                {
                    retorno.Status = "Recusado";
                    retorno.Impedimentos.Add("A quantidade de parcelas deve ser entre " + param.QtdMinParcela + " e " + param.QtdMaxParcela + " parcelas.");
                }

                var dataAtual = DateTime.Now;
                var dataMin = dataAtual.AddDays(param.MinDiasPrimeiroVencimento);
                var dataMax = dataAtual.AddDays(param.MaxDiasPrimeiroVencimento);

                if (proposta.DataPrimeiroVenc < dataMin || proposta.DataPrimeiroVenc > dataMax)
                {
                    retorno.Status = "Recusado";
                    retorno.Impedimentos.Add("A data do primeiro vencimento deverá ser no mínimo " + param.MinDiasPrimeiroVencimento +
                                             " dias e no máximo " + param.MaxDiasPrimeiroVencimento + " dias a partir da data atual.");
                }

                if (retorno.Status != "Recusado") { retorno.Status = "Aprovado"; }

                retorno.Tipo = param.TiposCredito[proposta.Tipo];
                retorno.ValorCreditoSolicitado = proposta.Valor;
                retorno.QtdParcelas = proposta.QtdParcelas;                
                retorno.DataPrimeiroVenc = proposta.DataPrimeiroVenc;

                return retorno;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
