using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MotorCreditoAPI.Model;
using MotorCreditoAPI.Services;

namespace MotorCreditoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LiberarCreditoController : ControllerBase
    {
        private readonly ICreditoConsignadoService _creditoConsignadoService;
        private readonly ICreditoDiretoService _creditoDiretoService;
        private readonly ICreditoImobiliarioService _creditoImobiliarioService;
        private readonly ICreditoPessoaFisicaService _creditoPessoaFisicaService;
        private readonly ICreditoPessoaJuridicaService _creditoPessoaJuridicaService;

        public LiberarCreditoController(
            ICreditoConsignadoService creditoConsignadoService,
            ICreditoDiretoService creditoDiretoService,
            ICreditoImobiliarioService creditoImobiliarioService,
            ICreditoPessoaFisicaService creditoPessoaFisicaService,
            ICreditoPessoaJuridicaService creditoPessoaJuridicaService
            )
        {
            _creditoConsignadoService = creditoConsignadoService;
            _creditoDiretoService = creditoDiretoService;
            _creditoImobiliarioService = creditoImobiliarioService;
            _creditoPessoaFisicaService = creditoPessoaFisicaService;
            _creditoPessoaJuridicaService = creditoPessoaJuridicaService;
        }


        [HttpPost("Consignado")]
        public IActionResult LiberarCreditoConsignado(PropostaCreditoDto proposta)
        {
            var propostaRetorno = _creditoConsignadoService.liberarCreditoConsignado(proposta);
            return propostaRetorno != null
                ? Ok(propostaRetorno)
                : BadRequest("Erro na liberação do crédito consignado");
        }


        [HttpPost("Direto")]
        public IActionResult LiberarCreditoDireto(PropostaCreditoDto proposta)
        {
            var propostaRetorno = _creditoDiretoService.liberarCreditoDireto(proposta);
            return propostaRetorno != null
               ? Ok(propostaRetorno)
               : BadRequest("Erro na liberação do crédito direto");
        }


        [HttpPost("Imobiliario")]
        public IActionResult LiberarCreditoImobiliario(PropostaCreditoDto proposta)
        {
            var propostaRetorno = _creditoImobiliarioService.liberarCreditoImobiliario(proposta);
            return propostaRetorno != null
               ? Ok(propostaRetorno)
               : BadRequest("Erro na liberação do crédito imobiliario");
        }


        [HttpPost("PessoaJuridica")]
        public IActionResult LiberaCreditoPessoaJuridica(PropostaCreditoDto proposta)
        {
            var propostaRetorno = _creditoPessoaJuridicaService.liberarCreditoPessoaJuridica(proposta);
            return propostaRetorno != null
               ? Ok(propostaRetorno)
               : BadRequest("Erro na liberação do crédito para pessoa jurídica");
        }


        [HttpPost("PessoaFisica")]
        public IActionResult LiberarCreditoPessoaFisica(PropostaCreditoDto proposta)
        {
            var propostaRetorno = _creditoPessoaFisicaService.liberarCreditoPessoaFisica(proposta);
            return propostaRetorno != null
               ? Ok(propostaRetorno)
               : BadRequest("Erro na liberação do crédito para pessoa fisica");
        }

    }





}
