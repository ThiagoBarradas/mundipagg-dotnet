using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class CreatePricingSchemeRequest
    {
        #region Public Properties

        public int? MinimumPrice { get; set; }

        public int? Price { get; set; }

        public List<CreatePriceBracketRequest> PriceBrackets { get; set; }

        public string SchemeType { get; set; }

        #endregion Public Properties
    }
}