using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class CreateRecipientRequest
    {
        #region Public Properties

        public CreateBankAccountRequest DefaultBankAccount { get; set; }

        public string Description { get; set; }

        public string Document { get; set; }

        public string Email { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Name { get; set; }

        public CreateTransferSettingsRequest TransferSettings { get; set; }

        public string Type { get; set; }

        #endregion Public Properties
    }
}