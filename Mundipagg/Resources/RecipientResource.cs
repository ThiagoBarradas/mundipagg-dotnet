﻿using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using RestSharp.Easy.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mundipagg.Resources
{
    public class RecipientResource : BaseResource, IRecipientResource
    {
        public RecipientResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> CreateRecipient(CreateRecipientRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/recipients";

            return this.SendRequest<GetRecipientResponse>(method, endpoint, request);
        }

        public async Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> CreateRecipientAsync(CreateRecipientRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/recipients";

            return await this.SendRequestAsync<GetRecipientResponse>(method, endpoint, request);
        }

        public BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> GetRecipient(string recipientId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/recipients/{recipientId}";

            return this.SendRequest<GetRecipientResponse>(method, endpoint, null);
        }

        public async Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> GetRecipientAsync(string recipientId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/recipients/{recipientId}";

            return await this.SendRequestAsync<GetRecipientResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetRecipientResponse>, MundipaggErrorsResponse> ListRecipients(ListRecipientsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/recipients";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetRecipientResponse>>(method, endpoint, null, query);
        }

        public async Task<BaseResponse<PagingResponse<GetRecipientResponse>, MundipaggErrorsResponse>> ListRecipientsAsync(ListRecipientsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/recipients";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<PagingResponse<GetRecipientResponse>>(method, endpoint, null, query);
        }

        public BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> UpdateRecipient(string recipientId, UpdateRecipientRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/recipients/{recipientId}";
 
            return this.SendRequest<GetRecipientResponse>(method, endpoint, request);
        }

        public async Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> UpdateRecipientAsync(string recipientId, UpdateRecipientRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/recipients/{recipientId}";

            return await this.SendRequestAsync<GetRecipientResponse>(method, endpoint, request);
        }

        public BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> UpdateTransferSettings(string recipientId, UpdateTransferSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/recipients/{recipientId}/transfer-settings";

            return this.SendRequest<GetRecipientResponse>(method, endpoint, request);
        }

        public async Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> UpdateTransferSettingsAsync(string recipientId, UpdateTransferSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/recipients/{recipientId}/transfer-settings";

            return await this.SendRequestAsync<GetRecipientResponse>(method, endpoint, request);
        }

        public BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> UpdateAutomaticAnticipationSettings(string recipientId, UpdateAutomaticAnticipationSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/recipients/{recipientId}/automatic-anticipation-settings";

            return this.SendRequest<GetRecipientResponse>(method, endpoint, request);
        }

        public async Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> UpdateAutomaticAnticipationSettingsAsync(string recipientId, UpdateAutomaticAnticipationSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/recipients/{recipientId}/automatic-anticipation-settings";

            return await this.SendRequestAsync<GetRecipientResponse>(method, endpoint, request);
        }

        public BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> UpdateDefaultBankAccount(string recipientId, UpdateRecipientDefaultBankAccountRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/recipients/{recipientId}/default-bank-account";

            return this.SendRequest<GetRecipientResponse>(method, endpoint, request);
        }

        public async Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> UpdateDefaultBankAccountAsync(string recipientId, UpdateRecipientDefaultBankAccountRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/recipients/{recipientId}/default-bank-account";

            return await this.SendRequestAsync<GetRecipientResponse>(method, endpoint, request);
        }

        public BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> ImportRecipient(CreateImportRecipientRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/recipients/import";

            return this.SendRequest<GetRecipientResponse>(method, endpoint, request);
        }

        public async Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> ImportRecipientAsync(CreateImportRecipientRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/recipients/import";

            return await this.SendRequestAsync<GetRecipientResponse>(method, endpoint, request);
        }

        public BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> GetRecipientByCode(string code)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/recipients/code/{code}";

            return this.SendRequest<GetRecipientResponse>(method, endpoint, null);
        }

        public async Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> GetRecipientByCodeAsync(string code)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/recipients/code/{code}";

            return await this.SendRequestAsync<GetRecipientResponse>(method, endpoint, null);
        }
    }
}