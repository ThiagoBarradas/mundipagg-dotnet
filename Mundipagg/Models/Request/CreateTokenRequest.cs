namespace Mundipagg.Models.Request
{
    public class CreateTokenRequest
    {
        public CreateCardTokenRequest Card { get; set; }

        public string Type { get; set; } = "card";
    }
}