using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class CreateCancelChargeRequest
    {
        #region Public Properties

        public int? Amount { get; set; }

        public List<CreateCancelChargeSplitRulesRequest> SplitRules { get; set; }

        #endregion Public Properties
    }
}