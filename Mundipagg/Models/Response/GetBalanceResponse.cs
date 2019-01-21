namespace Mundipagg.Models.Response
{
    public class GetBalanceResponse
    {

        public int AvailableAmount { get; set; }

        public string Currency { get; set; }

        public GetRecipientResponse Recipient { get; set; }

    }
}