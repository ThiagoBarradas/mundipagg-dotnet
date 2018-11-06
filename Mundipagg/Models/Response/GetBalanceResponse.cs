namespace Mundipagg.Models.Response
{
    public class GetBalanceResponse
    {
        #region Public Properties

        public int AvailableAmount { get; set; }

        public string Currency { get; set; }

        public GetRecipientResponse Recipient { get; set; }

        #endregion Public Properties
    }
}