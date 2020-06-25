namespace Mundipagg.Models.Request
{

    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateGeneralSettingsRequest
    {

        /// <summary>
        /// Nome
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Logo
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// E-mail de contato
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Site
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Tema da página
        /// </summary>
        public string Theme { get; set; }

        /// <summary>
        /// Código da conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Código do cliente
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// Cor primaria utilizada no chechout
        /// </summary>
        public string PrimaryColor { get; set; }

        /// <summary>
        /// Cor secundaria utilizada no checkout
        /// </summary>
        public string SecondaryColor { get; set; }

    }
}
