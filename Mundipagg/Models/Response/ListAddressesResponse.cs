using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListAddressesResponse
    {

        public List<GetAddressResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

    }
}