using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class BaseListRequest
    {
        public BaseListRequest()
        {
            this.Page = 1;
            this.Size = 10;
        }

        public int Page { get; set; }

        public int Size { get; set; }
    }
}