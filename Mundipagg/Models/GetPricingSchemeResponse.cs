using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class GetPricingSchemeResponse 
    {
        public int Price { get; set; }
        public string SchemeType { get; set; }
        public List<GetPriceBracketResponse> PriceBrackets { get; set; }
        public int? MinimumPrice { get; set; }
    }
} 