namespace validacao.Model
{
    public class CreditCardResponse
    {
        /// <summary>
        /// Número do cartão de crédito 
        /// </summary>
        /// <example>4716 5234 7211 8411</example>
        public string CardNumber { get; set; } = string.Empty;

        /// <summary>
        /// Indica se o cartão é válido
        /// </summary>
        /// <example>true</example>
        public bool IsValid { get; set; }

        /// <summary>
        /// Bandeira identificada do cartão
        /// </summary>
        /// <example>Visa</example>
        public string Brand { get; set; } = string.Empty;

        /// <summary>
        /// Mensagem de retorno
        /// </summary>
        /// <example>Cartão válido</example>
        public string Message { get; set; } = string.Empty;
    }
}
