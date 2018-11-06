using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class GetGatewayResponseResponse
    {
        #region Public Properties

        public string Code { get; set; }

        public List<GetGatewayErrorResponse> Errors { get; set; }

        #endregion Public Properties
    }
}