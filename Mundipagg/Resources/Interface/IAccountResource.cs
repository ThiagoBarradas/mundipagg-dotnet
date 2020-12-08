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
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> GetAccount(string accountId);

        /// <summary>
        /// List all accounts
        /// </summary>
        /// <returns></returns>
        BaseResponse<PagingResponse<GetAccountResponse>, MundipaggErrorsResponse> ListAccounts();

        /// <summary>
        /// Cretes a new account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> CreateAccount(CreateAccountRequest request);
        
        /// <summary>
        /// Get Account Info
        /// </summary>
        /// <param name="masterAccountId"></param>
        /// <returns></returns>
        BaseResponse<PagingResponse<GetAccountResponse>, MundipaggErrorsResponse> GetTestAccounts(string masterAccountId);

        /// <summary>
        /// Cretes a new account
        /// </summary>
        /// <param name="masterAccountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> CreateTestAccount(string masterAccountId, CreateAccountRequest request);
        
        /// <summary>
        /// Update Account
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateAccount(string accountId, UpdateAccountRequest request);

        /// <summary>
        /// Update Status
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateStatus(string accountId, UpdateAccountStatusRequest request);

        /// <summary>
        ///     
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="merchantKey"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateMundipaggConfig(string accountId, UpdateMundipaggConfigRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdatePagarmeConfig(string accountId, UpdatePagarmeConfigRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateCreditCardSettings(string accountId, UpdateCreditCardSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateDebitCardSettings(string accountId, UpdateDebitCardSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateBoletoSettings(string accountId, UpdateBoletoSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateBankTransferSettings(string accountId, UpdateBankTransferSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateWalletSettings(string accountId, UpdateWalletSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateSafetyPaySettings(string accountId, UpdateSafetyPaySettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateVoucherSettings(string accountId, UpdateVoucherSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateWebhookSettings(string accountId, UpdateWebhookSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateAttemptSettings(string accountId, UpdateAttemptSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateCheckoutSettings(string accountId, UpdateCheckoutSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateRenewCardSettings(string accountId, UpdateRenewCardSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateSplitSettings(string accountId, UpdateSplitSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateOrderSettings(string accountId, UpdateOrderSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateSubscriptionSettings(string accountId, UpdateSubscriptionSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateNotificationSettings(string accountId, UpdateNotificationSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateGuaranteedCancellationSettings(string accountId, UpdateGuaranteedCancellationSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateCashSettings(string accountId, UpdateCashSettingsRequest request);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateAntifraudSettings(string accountId, UpdateCashSettingsRequest request);

    }
}