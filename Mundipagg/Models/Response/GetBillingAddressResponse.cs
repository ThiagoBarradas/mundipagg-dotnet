using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetBillingAddressResponse
    {
        public string City { get; set; }

        public string Complement { get; set; }

        public string Country { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string Neighborhood { get; set; }

        public string Number { get; set; }

        public string State { get; set; }

        public string Street { get; set; }

        public string ZipCode { get; set; }
    }
}