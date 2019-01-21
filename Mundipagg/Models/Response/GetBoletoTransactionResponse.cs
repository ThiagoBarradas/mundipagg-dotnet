using System;

namespace Mundipagg.Models.Response
{
    public class GetBoletoTransactionResponse : GetTransactionResponse
    {
        public string Bank { get; set; }

        public string BarCode { get; set; }

        public GetBillingAddressResponse BillingAddress { get; set; }

        public DateTime? CreditAt { get; set; }

        public string DocumentNumber { get; set; }

        public DateTime? DueAt { get; set; }

        public string Instructions { get; set; }

        public string Line { get; set; }

        public string NossoNumero { get; set; }

        public string PaidAmount { get; set; }

        public DateTime? PaidAt { get; set; }

        public string Pdf { get; set; }

        public string PdfPassword { get; set; }

        public string QrCode { get; set; }

        public string Type { get; set; }

        public string Url { get; set; }
    }
}