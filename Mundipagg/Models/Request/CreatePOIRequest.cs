using System;

namespace Mundipagg.Models.Request
{
    public class CreatePOIRequest
    {
        public string InitiatorTransactionKey { get; set; }

        public string CardSequenceNumber { get; set; }

        public DateTime? InitiatorDate { get; set; }

        public string InitiatorReference { get; set; }

        public string IccData { get; set; }

        public CreateAuthenticationPOIRequest Authentication { get; set; }

        public CreateDevicePOIRequest Device { get; set; }

        public bool? IsFallback { get; set; }
    }
}
