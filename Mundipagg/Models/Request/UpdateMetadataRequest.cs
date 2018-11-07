using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class UpdateMetadataRequest
    {
        #region Public Properties

        public Dictionary<string, string> Metadata { get; set; }

        #endregion Public Properties
    }
}