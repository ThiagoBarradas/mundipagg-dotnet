using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class MundipaggErrorsResponse
    {
        public IDictionary<string, string[]> Errors { get; set; }

        public string Message { get; set; }
    }
}