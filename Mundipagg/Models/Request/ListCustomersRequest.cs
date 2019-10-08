using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListCustomersRequest : BaseListRequest
    {
        #region Properties

        public string Code { get; set; }

        public string Document { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        #endregion Properties
    }
}