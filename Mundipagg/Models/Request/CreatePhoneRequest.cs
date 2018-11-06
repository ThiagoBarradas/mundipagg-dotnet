namespace Mundipagg.Models.Request
{
    public class CreatePhoneRequest
    {
        #region Public Properties

        public string AreaCode { get; set; }

        public string CountryCode { get; set; }

        public string Number { get; set; }

        #endregion Public Properties
    }
}