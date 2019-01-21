namespace Mundipagg.Models.Request
{
    public class CreatePhonesRequest
    {
        public CreatePhoneRequest HomePhone { get; set; }

        public CreatePhoneRequest MobilePhone { get; set; }
    }
}