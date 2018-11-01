using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class CreateCancelChargeRequest 
    {
        public int? Amount { get; set; }
        public List<CreateCancelChargeSplitRulesRequest> SplitRules { get; set; }
    }
} 