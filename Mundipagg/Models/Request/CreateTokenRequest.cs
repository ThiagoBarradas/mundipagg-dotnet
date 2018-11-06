namespace Mundipagg.Models.Request
{
    public class CreateTokenRequest
    {
        #region Public Properties

        public CreateCardTokenRequest Card { get; set; }

        public string Type { get; set; } = "card";

        #endregion Public Properties
    }
}