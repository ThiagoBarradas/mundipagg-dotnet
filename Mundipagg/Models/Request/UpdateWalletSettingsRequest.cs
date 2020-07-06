using Newtonsoft.Json;

namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateWalletSettingsRequest
    {
        /// <summary>
        /// Indica se a configuração de wallet está habilitada
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Código da conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Código do cliente
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// Quantidade máxima de cartões
        /// </summary>
        [JsonProperty("max_cards")]
        public int MaxCardsCount { get; set; }

        /// <summary>
        /// Indica se a loja compartilha a wallet
        /// </summary>
        public bool Shared { get; set; }
    }
}
