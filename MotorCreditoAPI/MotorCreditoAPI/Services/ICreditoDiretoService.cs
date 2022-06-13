using MotorCreditoAPI.Model;

namespace MotorCreditoAPI.Services
{
    public interface ICreditoDiretoService
    {
        AnaliseCreditoDto liberarCreditoDireto(PropostaCreditoDto proposta);
        
    }
}
