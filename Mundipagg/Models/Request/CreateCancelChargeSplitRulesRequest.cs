namespace Mundipagg.Models.Request
{
    public class CreateCancelChargeSplitRulesRequest
    {
        public int Amount { get; set; }

        public string Id { get; set; }

        public string Type { get; set; }
    }
}