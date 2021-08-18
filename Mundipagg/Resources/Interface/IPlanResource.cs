using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;
using System.Threading.Tasks;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Subscription manager
    /// </summary>
    public interface IPlanResource : IResource
    {
        /// <summary>
        /// Lists all plans
        /// </summary>
        /// <param name="planId"></param>
        /// <returns></returns>
        BaseResponse<GetPlanResponse, MundipaggErrorsResponse> GetPlan(string planId);

        /// <summary>
        /// Lists all plans
        /// </summary>
        Task<BaseResponse<GetPlanResponse, MundipaggErrorsResponse>> GetPlanAsync(string planId);

        /// <summary>
        /// Lists all plans
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetPlanResponse>> response from the API call</return>
        /// <return>Returns Task<BaseResponse<PagingResponse<GetPlanResponse>>> response from the API call</return>
        BaseResponse<PagingResponse<GetPlanResponse>, MundipaggErrorsResponse> ListPlans(ListPlansRequest request);

        /// <summary>
        /// Lists all plans
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseResponse<PagingResponse<GetPlanResponse>, MundipaggErrorsResponse>> ListPlansAsync(ListPlansRequest request);
    }
}