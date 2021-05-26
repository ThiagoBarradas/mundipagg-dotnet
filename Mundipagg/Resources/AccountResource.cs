using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using RestSharp.Easy.Models;
using System.Net.Http;

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

        public BaseResponse<PagingResponse<GetAccountResponse>, MundipaggErrorsResponse> ListAccounts()
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts";

            return this.SendRequest<PagingResponse<GetAccountResponse>>(method, endpoint, null, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> CreateAccount(CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }
        
        public BaseResponse<PagingResponse<GetAccountResponse>, MundipaggErrorsResponse> GetTestAccounts(string masterAccountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return this.SendRequest<PagingResponse<GetAccountResponse>>(method, endpoint, null, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> CreateTestAccount(string masterAccountId, CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateAccount(string accountId, UpdateAccountRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/accounts/{accountId}";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateStatus(string accountId, UpdateAccountStatusRequest request) {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/status";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }
        
        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateMundipaggConfig(string accountId, UpdateMundipaggConfigRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/mundipagg-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdatePagarmeConfig(string accountId, UpdatePagarmeConfigRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/pagarme-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateCreditCardSettings(string accountId, UpdateCreditCardSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/credit-card-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdatePixSettings(string accountId, UpdatePixSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/pix-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateDebitCardSettings(string accountId, UpdateDebitCardSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/debit-card-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateBoletoSettings(string accountId, UpdateBoletoSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/boleto-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateBankTransferSettings(string accountId, UpdateBankTransferSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/bank-transfer-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateWalletSettings(string accountId, UpdateWalletSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/wallet-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateSafetyPaySettings(string accountId, UpdateSafetyPaySettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/safetypay-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateVoucherSettings(string accountId, UpdateVoucherSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/voucher-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateCheckoutSettings(string accountId, UpdateCheckoutSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/checkout-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateRenewCardSettings(string accountId, UpdateRenewCardSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/renew-card-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateSplitSettings(string accountId, UpdateSplitSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/split-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateOrderSettings(string accountId, UpdateOrderSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/order-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateSubscriptionSettings(string accountId, UpdateSubscriptionSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/subscription-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateNotificationSettings(string accountId, UpdateNotificationSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/notification-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateGuaranteedCancellationSettings(string accountId, UpdateGuaranteedCancellationSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/guaranteed-cancellation-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateCashSettings(string accountId, UpdateCashSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/cash-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateAntifraudSettings(string accountId, UpdateCashSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/antifraud-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateWebhookSettings(string accountId, UpdateWebhookSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/webhook-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateAttemptSettings(string accountId, UpdateAttemptSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/attempt-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }
    }
}