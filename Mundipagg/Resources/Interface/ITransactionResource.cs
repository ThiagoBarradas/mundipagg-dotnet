using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;
using System.Collections.Generic;

namespace Mundipagg.Resources.Interface
{
    public interface ITransactionResource : IResource
    {
        BaseResponse<List<GetTransactionResponse>, MundipaggErrorsResponse> GetTransactions(GetTransactionsRequest request);
    }
}
