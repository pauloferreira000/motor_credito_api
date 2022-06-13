using MotorCreditoAPI.Model;

namespace MotorCreditoAPI.Services
{
    public interface ICreditoPessoaJuridicaService
    {
        AnaliseCreditoDto liberarCreditoPessoaJuridica(PropostaCreditoDto proposta);
    }
}
