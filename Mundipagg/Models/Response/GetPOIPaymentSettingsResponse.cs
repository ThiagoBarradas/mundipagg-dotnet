using System;
using System.Collections.Generic;
using System.Text;

namespace Mundipagg.Models.Response
{
    public class GetPOIPaymentSettingsResponse
    {
        public bool? Visible { get; set; }

        public string FilterCode { get; set; }

        public string DisplayName { get; set; }

        public bool? PrintOrderReciept { get; set; }

        public bool? PrintCustomerReciept { get; set; }

        public bool? PrintSellerReciept { get; set; }

        public bool? AllowOverPayment { get; set; }

        public string Source { get; set; }

        public GetPOIPaymentSetupResponse PaymentSetup { get; set; }

        public string[] TerminalList { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
