using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using RestSharp.Easy.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mundipagg.Resources
{
    public class AccountResource : BaseResource, IAccountResource
    {
        public AccountResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> GetAccount(string accountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts/{accountId}";

            return this.SendRequest<GetAccountResponse>(method, endpoint, null, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> GetAccountAsync(string accountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts/{accountId}";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, null, authMode: "amk");
        }


        public BaseResponse<PagingResponse<GetAccountResponse>, MundipaggErrorsResponse> ListAccounts()
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts";

            return this.SendRequest<PagingResponse<GetAccountResponse>>(method, endpoint, null, authMode: "amk");
        }


        public async Task<BaseResponse<PagingResponse<GetAccountResponse>, MundipaggErrorsResponse>> ListAccountsAsync()
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts";

            return await this.SendRequestAsync<PagingResponse<GetAccountResponse>>(method, endpoint, null, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> CreateAccount(CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> CreateAccountAsync(CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<PagingResponse<GetAccountResponse>, MundipaggErrorsResponse> GetTestAccounts(string masterAccountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return this.SendRequest<PagingResponse<GetAccountResponse>>(method, endpoint, null, authMode: "amk");
        }


        public async Task<BaseResponse<PagingResponse<GetAccountResponse>, MundipaggErrorsResponse>> GetTestAccountsAsync(string masterAccountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return await this.SendRequestAsync<PagingResponse<GetAccountResponse>>(method, endpoint, null, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> CreateTestAccount(string masterAccountId, CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> CreateTestAccountAsync(string masterAccountId, CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateAccount(string accountId, UpdateAccountRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/accounts/{accountId}";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateAccountAsync(string accountId, UpdateAccountRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/accounts/{accountId}";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateStatus(string accountId, UpdateAccountStatusRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/status";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateStatusAsync(string accountId, UpdateAccountStatusRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/status";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateMundipaggConfig(string accountId, UpdateMundipaggConfigRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/mundipagg-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateMundipaggConfigAsync(string accountId, UpdateMundipaggConfigRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/mundipagg-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdatePagarmeConfig(string accountId, UpdatePagarmeConfigRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/pagarme-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdatePagarmeConfigAsync(string accountId, UpdatePagarmeConfigRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/pagarme-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateCreditCardSettings(string accountId, UpdateCreditCardSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/credit-card-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateCreditCardSettingsAsync(string accountId, UpdateCreditCardSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/credit-card-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdatePixSettings(string accountId, UpdatePixSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/pix-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdatePixSettingsAsync(string accountId, UpdatePixSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/pix-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateDebitCardSettings(string accountId, UpdateDebitCardSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/debit-card-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateDebitCardSettingsAsync(string accountId, UpdateDebitCardSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/debit-card-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateBoletoSettings(string accountId, UpdateBoletoSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/boleto-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateBoletoSettingsAsync(string accountId, UpdateBoletoSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/boleto-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateBankTransferSettings(string accountId, UpdateBankTransferSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/bank-transfer-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateBankTransferSettingsAsync(string accountId, UpdateBankTransferSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/bank-transfer-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateWalletSettings(string accountId, UpdateWalletSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/wallet-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateWalletSettingsAsync(string accountId, UpdateWalletSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/wallet-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateSafetyPaySettings(string accountId, UpdateSafetyPaySettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/safetypay-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateSafetyPaySettingsAsync(string accountId, UpdateSafetyPaySettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/safetypay-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateVoucherSettings(string accountId, UpdateVoucherSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/voucher-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateVoucherSettingsAsync(string accountId, UpdateVoucherSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/voucher-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateCheckoutSettings(string accountId, UpdateCheckoutSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/checkout-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateCheckoutSettingsAsync(string accountId, UpdateCheckoutSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/checkout-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateRenewCardSettings(string accountId, UpdateRenewCardSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/renew-card-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateRenewCardSettingsAsync(string accountId, UpdateRenewCardSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/renew-card-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateSplitSettings(string accountId, UpdateSplitSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/split-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateSplitSettingsAsync(string accountId, UpdateSplitSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/split-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateOrderSettings(string accountId, UpdateOrderSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/order-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateOrderSettingsAsync(string accountId, UpdateOrderSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/order-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateSubscriptionSettings(string accountId, UpdateSubscriptionSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/subscription-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateSubscriptionSettingsAsync(string accountId, UpdateSubscriptionSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/subscription-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateNotificationSettings(string accountId, UpdateNotificationSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/notification-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateNotificationSettingsAsync(string accountId, UpdateNotificationSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/notification-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateGuaranteedCancellationSettings(string accountId, UpdateGuaranteedCancellationSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/guaranteed-cancellation-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateGuaranteedCancellationSettingsAsync(string accountId, UpdateGuaranteedCancellationSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/guaranteed-cancellation-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateCashSettings(string accountId, UpdateCashSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/cash-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateCashSettingsAsync(string accountId, UpdateCashSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/cash-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateAntifraudSettings(string accountId, UpdateCashSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/antifraud-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateAntifraudSettingsAsync(string accountId, UpdateCashSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/antifraud-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateWebhookSettings(string accountId, UpdateWebhookSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/webhook-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateWebhookSettingsAsync(string accountId, UpdateWebhookSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/webhook-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateAttemptSettings(string accountId, UpdateAttemptSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/attempt-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }


        public async Task<BaseResponse<GetAccountResponse, MundipaggErrorsResponse>> UpdateAttemptSettingsAsync(string accountId, UpdateAttemptSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/attempt-settings";

            return await this.SendRequestAsync<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }
    }
}