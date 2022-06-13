using MotorCreditoAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotorCreditoAPI.Services
{
    public class CreditoPessoaJuridicaService : ICreditoPessoaJuridicaService
    {
        public AnaliseCreditoDto liberarCreditoPessoaJuridica(PropostaCreditoDto proposta)
        {

            try
            {
                var param = new ParametrosConcessao();
                var retornoAnalise = new AnaliseCreditoDto();

                if (proposta.Tipo == 3)
                {
                    IMotorCreditoService motor = new MotorCreditoService();
                    retornoAnalise = motor.validarRegrasGeraisCredito(proposta);
                    retornoAnalise.TaxaJuros = Convert.ToString(param.TaxaCredPessoaFisica) + "%";

                    if (retornoAnalise.Status == "Aprovado")
                    {
                        if (proposta.Valor < param.ValMinPessoaJuridica)
                        {
                            retornoAnalise.Status = "Recusado";
                            retornoAnalise.Impedimentos.Add("O valor mínimo de crédito para pessoa juridica é de " + param.ValMinPessoaJuridica + ".");
                        }
                        else
                        {
                            retornoAnalise.ValorJuros = proposta.Valor * param.TaxaCredPessoaFisica * proposta.QtdParcelas / 100;
                            retornoAnalise.ValorTotalComJuros = proposta.Valor + retornoAnalise.ValorJuros;                            
                        }
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
