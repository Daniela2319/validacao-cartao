using validacao.Model;

namespace validacao.SwaggerExamples
{
    /// <summary>
    /// Exemplo de resposta Swagger para um cartão de crédito válido.
    /// 
    /// Esta classe é utilizada exclusivamente na documentação da API (Swagger)
    /// para demonstrar um retorno de sucesso (HTTP 200) do endpoint de validação
    /// de cartão de crédito.
    /// 
    /// Não representa uma entidade de domínio nem participa da lógica da aplicação.
    /// </summary>
    public class CreditCardValidExample 
    {
        /// <summary>
        /// Retorna um exemplo de resposta indicando que o cartão é válido.
        /// </summary>
        /// <returns>Objeto <see cref="CreditCardResponse"/> com dados de cartão válido.</returns>
        public CreditCardResponse GetExamples()
        {
            return new CreditCardResponse
            {
                CardNumber = "4716 5234 7211 8411",
                IsValid = true,
                Brand = "Visa",
                Message = "Cartão válido"
            };
        }
    }
}

