using MotorCreditoAPI.Model;

namespace MotorCreditoAPI.Services
{
    public interface ICreditoPessoaFisicaService
    {
        AnaliseCreditoDto liberarCreditoPessoaFisica(PropostaCreditoDto proposta);
    }
}
