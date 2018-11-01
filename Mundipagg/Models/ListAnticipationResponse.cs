using Newtonsoft.Json;
using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class ListAnticipationResponse 
    {
        public List<GetAnticipationResponse> Data { get; set; }
        public PagingResponse Paging { get; set; }
    }
} 