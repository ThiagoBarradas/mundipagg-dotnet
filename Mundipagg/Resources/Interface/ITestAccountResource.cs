using Mundipagg.Models.Request;
using Mundipagg.Models.Response;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Account manager
    /// </summary>
    public interface ITestAccountResource : IResource
    {
        /// <summary>
        /// Get Account Info
        /// </summary>
        /// <param name="masterAccountId"></param>
        /// <returns></returns>
        BaseResponse<ListAccountsResponse> GetAccounts(string masterAccountId);

        /// <summary>
        /// Cretes a new account
        /// </summary>
        /// <param name="masterAccountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse> CreateAccount(string masterAccountId, CreateAccountRequest request);
    }
}