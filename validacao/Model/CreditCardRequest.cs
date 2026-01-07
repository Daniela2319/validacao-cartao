using System.ComponentModel.DataAnnotations;

namespace validacao.Model
{
    public class CreditCardRequest
    {
        /// <summary>
        /// Número do cartão de crédito 
        /// </summary>
        /// <example>4716 5234 7211 8411</example>
        [Required]
        public string CardNumber { get; set; } = string.Empty;
        
    }
}
