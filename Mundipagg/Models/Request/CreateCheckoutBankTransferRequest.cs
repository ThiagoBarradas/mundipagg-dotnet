using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class CreateCheckoutBankTransferRequest
    {
        #region Public Properties

        public List<string> Bank { get; set; }

        public int Retries { get; set; }

        #endregion Public Properties
    }
}