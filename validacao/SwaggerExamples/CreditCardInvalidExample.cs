using Swashbuckle.AspNetCore.Filters;
using validacao.Model;

namespace validacao.SwaggerExamples
{
    /// <summary>
    /// Exemplo de resposta Swagger para um cartão de crédito inválido.
    /// 
    /// Utilizado exclusivamente na documentação da API para ilustrar
    /// um retorno de erro (HTTP 400) no endpoint de validação de cartão.
    /// 
    /// Esta classe não faz parte da regra de negócio nem do domínio.
    /// </summary>
    public class CreditCardInvalidExample
    {
        /// <summary>
        /// Retorna um exemplo de resposta indicando que o cartão é inválido.
        /// </summary>
        /// <returns>
        /// Um objeto <see cref="CreditCardResponse"/> representando um cartão inválido.
        /// </returns>
        public CreditCardResponse GetExamples()
        {
            return new CreditCardResponse
            {
                CardNumber = "1234 5678 9012 3456",
                IsValid = false,
                Brand = "Unknown",
                Message = "Cartão inválido"
            };
        }
    }
}

