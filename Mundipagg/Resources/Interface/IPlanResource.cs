using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Subscription manager
    /// </summary>
    public interface IPlanResource : IResource
    {
        /// <summary>
        /// Gets a plan
        /// </summary>
        /// <param name="planId">Required parameter: Plan id</param>
        /// <return>Returns BaseResponse<GetPlanResponse> response from the API call</return>
        BaseResponse<GetPlanResponse, MundipaggErrorsResponse> GetPlan(string planId);

        /// <summary>
        /// Lists all plans
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetPlanResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetPlanResponse>, MundipaggErrorsResponse> ListPlans(ListPlansRequest request);
    }
}