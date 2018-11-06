using System;

namespace Mundipagg.Models.Request
{
    public class CreateCheckoutBoletoPaymentRequest
    {
        #region Public Properties

        public string Bank { get; set; }

        public DateTime DueAt { get; set; }

        public string Instructions { get; set; }

        #endregion Public Properties
    }
}