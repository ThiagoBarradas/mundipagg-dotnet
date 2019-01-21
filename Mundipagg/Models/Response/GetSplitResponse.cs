namespace Mundipagg.Models.Response
{
    public class GetSplitResponse
    {

        public int Amount { get; set; }

        public string GatewayId { get; set; }

        public GetRecipientResponse Recipient { get; set; }

        public string Type { get; set; }

    }
}