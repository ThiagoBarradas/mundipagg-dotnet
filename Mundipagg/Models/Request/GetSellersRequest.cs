namespace Mundipagg.Models.Request
{
    public class GetSellersRequest
    {

        public string Code { get; set; }

        public string CreatedSince { get; set; }

        public string CreatedUntil { get; set; }

        public string Document { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }

    }
}