using Microsoft.AspNetCore.Mvc;
using validacao.Model;
using validacao.Service;
using validacao.SwaggerExamples;

namespace CreditCard.Api.Controllers
{
    [ApiController]
    [Route("api/creditcard")]
    [Produces("application/json")]
    public class CreditCardController : ControllerBase
    {
        /// <summary>
        /// Valida um número de cartão de crédito
        /// </summary>
        /// <remarks>
        /// Este endpoint realiza:
        /// - Validação do número do cartão usando o algoritmo de Luhn
        /// - Identificação da bandeira do cartão
        ///
        /// </remarks>
        /// <param name="request">Objeto contendo o número do cartão</param>
        /// <returns>Resultado da validação do cartão</returns>
        /// <response code="200">Cartão válido</response>
        /// <response code="400">Número do cartão não informado ou cartão inválido</response>
        [HttpPost("validate")]
        [ProducesResponseType(typeof(CreditCardValidExample), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CreditCardInvalidExample), StatusCodes.Status400BadRequest)]
        public IActionResult Validate([FromBody] CreditCardRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.CardNumber))
            {
                return BadRequest(new CreditCardResponse
                {
                    CardNumber = null,
                    IsValid = false,
                    Brand = null,
                    Message = "Número do cartão é obrigatório"
                });
            }

            bool isValid = LuhnValidator.IsValid(request.CardNumber);
            if (!isValid)
            {
                return BadRequest(new CreditCardResponse
                {
                    CardNumber = request.CardNumber,
                    IsValid = false,
                    Brand = "Unknown",
                    Message = "Cartão inválido"
                });
            }

            // Cartão válido
            return Ok(new CreditCardResponse
            {
                CardNumber = request.CardNumber,
                IsValid = true,
                Brand = CardBrandService.Identify(request.CardNumber),
                Message = "Cartão válido"
            });
        }
    }
}
