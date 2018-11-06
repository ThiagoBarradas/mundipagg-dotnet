using System;

namespace Mundipagg.Models.Response
{
    public class GetCheckoutBoletoPaymentResponse
    {
        #region Public Properties

        public DateTime DueAt { get; set; }

        public string Instructions { get; set; }

        #endregion Public Properties
    }
}