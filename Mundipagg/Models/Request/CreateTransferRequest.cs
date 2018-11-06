using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class CreateTransferRequest
    {
        #region Public Properties

        public int Amount { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        #endregion Public Properties
    }
}