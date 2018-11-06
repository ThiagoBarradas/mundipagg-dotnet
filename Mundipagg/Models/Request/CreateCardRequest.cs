using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class CreateCardRequest
    {
        #region Public Properties

        public CreateAddressRequest BillingAddress { get; set; }

        public string BillingAddressId { get; set; }

        public string Brand { get; set; }

        public string Cvv { get; set; }

        public int ExpMonth { get; set; }

        public int ExpYear { get; set; }

        public string HolderDocument { get; set; }

        public string HolderName { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Number { get; set; }

        public CreateCardOptionsRequest Options { get; set; }

        public bool PrivateLabel { get; set; }

        public string Type { get; set; } = "credit";

        #endregion Public Properties
    }
}