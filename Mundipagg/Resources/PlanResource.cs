using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace Mundipagg.Resources
{
    public class PlanResource : BaseResource, IPlanResource
    {
        public PlanResource(Configuration configuration) : base(configuration)
        {
        }

        public BaseResponse<GetPlanResponse, MundipaggErrorsResponse> GetPlan(string planId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/plans/{planId}";

            return this.SendRequest<GetPlanResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetPlanResponse>, MundipaggErrorsResponse> ListPlans(ListPlansRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/plans";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetPlanResponse>>(method, endpoint, null, query);
        }
    }
}