using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class GetCheckoutPaymentSettingsResponse
    {
        #region Public Properties

        public List<string> AcceptedPaymentMethods { get; set; }

        public int? Amount { get; set; }

        public GetCustomerResponse Customer { get; set; }

        public string DefaultPaymentMethod { get; set; }

        public string GatewayAffiliationId { get; set; }

        public string PaymentUrl { get; set; }

        public string Status { get; set; }

        public string SuccessUrl { get; set; }

        #endregion Public Properties
    }
}