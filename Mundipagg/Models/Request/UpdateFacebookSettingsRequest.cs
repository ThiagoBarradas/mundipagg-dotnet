namespace Mundipagg.Models.Request
{

    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateFacebookSettingsRequest
    {

        /// <summary>
        /// Código do aplicativo no Facebook
        /// </summary>
        public long? AppId { get; set; }

        /// <summary>
        /// Chave secreta do aplicativo no Facebook
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// Permissões no Facebook
        /// </summary>
        public string[] Permissions { get; set; }

        /// <summary>
        /// Código da conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Código do cliente
        /// </summary>
        public string MerchantId { get; set; }
    }
}
