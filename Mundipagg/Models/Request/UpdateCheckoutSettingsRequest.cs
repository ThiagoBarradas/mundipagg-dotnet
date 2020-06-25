using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateCheckoutSettingsRequest : IValidatableObject
    {

        /// <summary>
        /// Código da conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Código do cliente
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// Url de redirecionamento de sucesso no pagamento
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Meios de pagamento habilitados no checkout
        /// </summary>
        [JsonProperty("accepted_payment_methods")]
        public string[] AcceptedPaymentMethods { get; set; }

        /// <summary>
        /// Meio de pagamento padrão
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Bandeiras aceitas
        /// </summary>
        [JsonProperty("accepted_brands")]
        public string[] AcceptedBrands { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Tipo de Endereço  - Global ou Brazlian
        /// </summary>
        [StringLength(16), Required]
        [JsonProperty("address_type")]
        public string AddressType { get; set; }

        /// <summary>
        /// Indica se Checkout Redirect está habilitado 
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Campos obrigatórios no Checkout.
        /// </summary>
        [JsonProperty("required_fields")]
        public string[] RequiredFields { get; set; }

        /// <summary>
        /// Campos opcionais no Checkout
        /// </summary>
        [JsonProperty("optional_fields")]
        public string[] OptionalFields { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            var addressType = this.AddressType?.ToUpper();

            if (new string[] { "BRAZILIAN", "GLOBAL" }.Contains(addressType) == false)
            {
                results.Add(new ValidationResult("The address_type field is invalid. Possible values are brazilian or global.", new string[] { "address_type" }));
            }

            return results;
        }
    }
}
