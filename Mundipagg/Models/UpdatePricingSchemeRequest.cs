using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class UpdatePricingSchemeRequest 
    {
        public string SchemeType { get; set; }
        public List<UpdatePriceBracketRequest> PriceBrackets { get; set; }
        public int? Price { get; set; }
        public int? MinimumPrice { get; set; }
    }
} 