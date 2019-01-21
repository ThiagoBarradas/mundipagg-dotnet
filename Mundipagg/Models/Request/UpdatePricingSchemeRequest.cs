using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class UpdatePricingSchemeRequest
    {
        public int? MinimumPrice { get; set; }

        public int? Price { get; set; }

        public List<UpdatePriceBracketRequest> PriceBrackets { get; set; }

        public string SchemeType { get; set; }
    }
}