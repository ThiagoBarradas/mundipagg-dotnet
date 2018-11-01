using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class GetCheckoutPaymentSettingsResponse 
    {
        public string SuccessUrl { get; set; }
        public string PaymentUrl { get; set; }
        public List<string> AcceptedPaymentMethods { get; set; }
        public string Status { get; set; }
        public GetCustomerResponse Customer { get; set; }
        public int? Amount { get; set; }
        public string DefaultPaymentMethod { get; set; }
        public string GatewayAffiliationId { get; set; }
    }
} 