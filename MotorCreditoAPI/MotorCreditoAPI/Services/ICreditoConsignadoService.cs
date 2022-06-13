using MotorCreditoAPI.Model;

namespace MotorCreditoAPI.Services
{
    public interface ICreditoConsignadoService
    {
        AnaliseCreditoDto liberarCreditoConsignado(PropostaCreditoDto proposta);
    }
}
