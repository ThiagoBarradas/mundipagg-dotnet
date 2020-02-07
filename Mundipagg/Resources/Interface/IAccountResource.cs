using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Account manager
    /// </summary>
    public interface IAccountResource : IResource
    {
        /// <summary>
        /// Get Account Info
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, ErrorsResponse> GetAccount(string accountId);

        /// <summary>
        /// List all accounts
        /// </summary>
        /// <returns></returns>
        BaseResponse<PagingResponse<GetAccountResponse>, ErrorsResponse> ListAccounts();

        /// <summary>
        /// Cretes a new account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, ErrorsResponse> CreateAccount(CreateAccountRequest request);
        
        /// <summary>
        /// Get Account Info
        /// </summary>
        /// <param name="masterAccountId"></param>
        /// <returns></returns>
        BaseResponse<ListAccountsResponse, ErrorsResponse> GetTestAccounts(string masterAccountId);

        /// <summary>
        /// Cretes a new account
        /// </summary>
        /// <param name="masterAccountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, ErrorsResponse> CreateTestAccount(string masterAccountId, CreateAccountRequest request);
        
        /// <summary>
        /// Update Account
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, ErrorsResponse> UpdateAccount(string accountId, UpdateAccountRequest request);

        /// <summary>
        /// Update Status
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, ErrorsResponse> UpdateStatus(string accountId, UpdateAccountStatusRequest request);

        /// <summary>
        ///     
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="merchantKey"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, ErrorsResponse> UpdateMundipaggConfig(string accountId, string merchantKey);
    }
}