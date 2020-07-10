using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateGeneralSettingsRequest
    {
        public string DisplayName { get; set; }

        public string Logo { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        public string Theme { get; set; }

        public string PrimaryColor { get; set; }

        public string SecondaryColor { get; set; }
    }
}
