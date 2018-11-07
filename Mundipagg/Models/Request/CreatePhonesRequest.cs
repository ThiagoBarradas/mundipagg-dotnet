namespace Mundipagg.Models.Request
{
    public class CreatePhonesRequest
    {
        #region Public Properties

        public CreatePhoneRequest HomePhone { get; set; }

        public CreatePhoneRequest MobilePhone { get; set; }

        #endregion Public Properties
    }
}