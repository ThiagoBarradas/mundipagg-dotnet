using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class UpdateSellerRequest
    {
        #region Public Properties

        public CreateAddressRequest Address { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string Document { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }

        #endregion Public Properties
    }
}