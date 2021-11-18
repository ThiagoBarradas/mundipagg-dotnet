using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using RestSharp.Easy.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mundipagg.Resources
{
    public class TransactionResource : BaseResource, ITransactionResource
    {
        public TransactionResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<List<GetTransactionResponse>, MundipaggErrorsResponse> GetTransactions(GetTransactionsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/transactions";
            var query = request.ToDictionary();

            return this.SendRequest<List<GetTransactionResponse>>(method, endpoint, null, query);
        }

         public async Task<BaseResponse<List<GetTransactionResponse>, MundipaggErrorsResponse>> GetTransactionsAsync(GetTransactionsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/transactions";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<List<GetTransactionResponse>>(method, endpoint, null, query);
        }
    }
}
