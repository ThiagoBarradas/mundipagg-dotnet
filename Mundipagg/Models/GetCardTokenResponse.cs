namespace Mundipagg.Models
{
    public class GetCardTokenResponse
    {
        public string LastFourDigits { get; set; }
        public string HolderName { get; set; }
        public string HolderDocument { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
    }
} 