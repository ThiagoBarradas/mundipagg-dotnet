using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class CreateRecipientRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Document { get; set; }
        public string Type { get; set; }
        public CreateBankAccountRequest DefaultBankAccount { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public CreateTransferSettingsRequest TransferSettings { get; set; }
    }
} 