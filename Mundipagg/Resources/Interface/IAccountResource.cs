using Mundipagg.Models.Request;
using Mundipagg.Models.Response;

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
        BaseResponse<GetAccountResponse> GetAccount(string accountId);

        /// <summary>
        /// Cretes a new account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse> CreateAccount(CreateAccountRequest request);
        
        /// <summary>
        /// Get Account Info
        /// </summary>
        /// <param name="masterAccountId"></param>
        /// <returns></returns>
        BaseResponse<ListAccountsResponse> GetTestAccounts(string masterAccountId);

        /// <summary>
        /// Cretes a new account
        /// </summary>
        /// <param name="masterAccountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse> CreateTestAccount(string masterAccountId, CreateAccountRequest request);
        
        /// <summary>
        /// Update Account
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse> UpdateAccount(string accountId, UpdateAccountRequest request);

        /// <summary>
        /// Update Status
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse> UpdateStatus(string accountId, UpdateAccountStatusRequest request);

        /// <summary>
        ///     
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="merchantKey"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse> UpdateMundipaggConfig(string accountId, string merchantKey);
    }
}