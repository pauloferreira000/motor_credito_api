using MotorCreditoAPI.Model;
using System;
using System.Collections.Generic;

namespace MotorCreditoAPI.Services
{
    public class CreditoDiretoService: ICreditoDiretoService
    {
        public AnaliseCreditoDto liberarCreditoDireto(PropostaCreditoDto proposta)
        {
            try
            {
                var param = new ParametrosConcessao();
                var retornoAnalise = new AnaliseCreditoDto();

                if (proposta.Tipo == 1)
                {
                    IMotorCreditoService motor = new MotorCreditoService();
                    retornoAnalise = motor.validarRegrasGeraisCredito(proposta);
                    retornoAnalise.TaxaJuros = Convert.ToString(param.TaxaCredPessoaFisica) + "%";

                    if (retornoAnalise.Status == "Aprovado")
                    {
                        retornoAnalise.ValorJuros = proposta.Valor * param.TaxaCredPessoaFisica * proposta.QtdParcelas / 100;
                        retornoAnalise.ValorTotalComJuros = proposta.Valor + retornoAnalise.ValorJuros;                       
                    }
                }
                else
                {
                    retornoAnalise.Impedimentos = new List<string>();
                    retornoAnalise.Impedimentos.Add("Não analisado - o tipo de credito informado é inadequado para este serviço");
                }
                return retornoAnalise;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
