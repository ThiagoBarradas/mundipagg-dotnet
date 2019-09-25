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
    }
}