using MotorCreditoAPI.Model;

namespace MotorCreditoAPI.Services
{
    public interface ICreditoImobiliarioService
    {
        AnaliseCreditoDto liberarCreditoImobiliario(PropostaCreditoDto proposta);
    }
}
