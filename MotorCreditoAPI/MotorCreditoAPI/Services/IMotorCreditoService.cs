using MotorCreditoAPI.Model;

namespace MotorCreditoAPI.Services
{
    public interface IMotorCreditoService
    {
        AnaliseCreditoDto validarRegrasGeraisCredito(PropostaCreditoDto proposta);
    }
}
