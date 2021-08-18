using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using RestSharp.Easy.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mundipagg.Resources
{
    public class CustomerResource : BaseResource, ICustomerResource
    {
        public CustomerResource(Configuration configuration) : base(configuration) { }

        #region Customer

        public BaseResponse<GetCustomerResponse, MundipaggErrorsResponse> CreateCustomer(CreateCustomerRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers";

            return this.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetCustomerResponse, MundipaggErrorsResponse>> CreateCustomerAsync(CreateCustomerRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers";

            return await this.SendRequestAsync<GetCustomerResponse>(method, endpoint, request);
        }


        public BaseResponse<GetCustomerResponse, MundipaggErrorsResponse> GetCustomer(string customerId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}";

            return this.SendRequest<GetCustomerResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetCustomerResponse, MundipaggErrorsResponse>> GetCustomerAsync(string customerId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}";

            return await this.SendRequestAsync<GetCustomerResponse>(method, endpoint, null);
        }


        public BaseResponse<PagingResponse<GetCustomerResponse>, MundipaggErrorsResponse> ListCustomers(ListCustomersRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetCustomerResponse>>(method, endpoint, query: query);
        }


        public async Task<BaseResponse<PagingResponse<GetCustomerResponse>, MundipaggErrorsResponse>> ListCustomersAsync(ListCustomersRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<PagingResponse<GetCustomerResponse>>(method, endpoint, query: query);
        }


        public BaseResponse<GetCustomerResponse, MundipaggErrorsResponse> UpdateCustomer(string customerId, UpdateCustomerRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}";

            return this.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetCustomerResponse, MundipaggErrorsResponse>> UpdateCustomerAsync(string customerId, UpdateCustomerRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}";

            return await this.SendRequestAsync<GetCustomerResponse>(method, endpoint, request);
        }


        public BaseResponse<GetCustomerResponse, MundipaggErrorsResponse> UpdateCustomerMetadata(string customerId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/customers/{customerId}/metadata";

            return this.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetCustomerResponse, MundipaggErrorsResponse>> UpdateCustomerMetadataAsync(string customerId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/customers/{customerId}/metadata";

            return await this.SendRequestAsync<GetCustomerResponse>(method, endpoint, request);
        }
        #endregion

        #region Address

        public BaseResponse<GetAddressResponse, MundipaggErrorsResponse> CreateAddress(string customerId, CreateAddressRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/addresses";

            return this.SendRequest<GetAddressResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetAddressResponse, MundipaggErrorsResponse>> CreateAddressAsync(string customerId, CreateAddressRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/addresses";

            return await this.SendRequestAsync<GetAddressResponse>(method, endpoint, request);
        }


        public BaseResponse<GetAddressResponse, MundipaggErrorsResponse> DeleteAddress(string customerId, string addressId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return this.SendRequest<GetAddressResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetAddressResponse, MundipaggErrorsResponse>> DeleteAddressAsync(string customerId, string addressId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return await this.SendRequestAsync<GetAddressResponse>(method, endpoint, null);
        }


        public BaseResponse<GetAddressResponse, MundipaggErrorsResponse> GetAddress(string customerId, string addressId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return this.SendRequest<GetAddressResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetAddressResponse, MundipaggErrorsResponse>> GetAddressAsync(string customerId, string addressId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return await this.SendRequestAsync<GetAddressResponse>(method, endpoint, null);
        }


        public BaseResponse<PagingResponse<GetAddressResponse>, MundipaggErrorsResponse> ListAddresses(ListAddressesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/addresses";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetAddressResponse>>(method, endpoint, query);
        }


        public async Task<BaseResponse<PagingResponse<GetAddressResponse>, MundipaggErrorsResponse>> ListAddressesAsync(ListAddressesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/addresses";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<PagingResponse<GetAddressResponse>>(method, endpoint, query);
        }


        public BaseResponse<GetAddressResponse, MundipaggErrorsResponse> UpdateAddress(string customerId, string addressId, UpdateAddressRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return this.SendRequest<GetAddressResponse>(method, endpoint, request);
        }

        public async Task<BaseResponse<GetAddressResponse, MundipaggErrorsResponse>> UpdateAddressAsync(string customerId, string addressId, UpdateAddressRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return await this.SendRequestAsync<GetAddressResponse>(method, endpoint, request);
        }

        #endregion

        #region Card

        public BaseResponse<GetCardResponse, MundipaggErrorsResponse> CreateCard(string customerId, CreateCardRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/cards";

            return this.SendRequest<GetCardResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetCardResponse, MundipaggErrorsResponse>> CreateCardAsync(string customerId, CreateCardRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/cards";

            return await this.SendRequestAsync<GetCardResponse>(method, endpoint, request);
        }


        public BaseResponse<GetCardResponse, MundipaggErrorsResponse> GetCard(string customerId, string cardId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return this.SendRequest<GetCardResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetCardResponse, MundipaggErrorsResponse>> GetCardAsync(string customerId, string cardId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return await this.SendRequestAsync<GetCardResponse>(method, endpoint, null);
        }


        public BaseResponse<PagingResponse<GetCardResponse>, MundipaggErrorsResponse> ListCards(ListCardsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/cards";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetCardResponse>>(method, endpoint, query);
        }


        public async Task<BaseResponse<PagingResponse<GetCardResponse>, MundipaggErrorsResponse>> ListCardsAsync(ListCardsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/cards";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<PagingResponse<GetCardResponse>>(method, endpoint, query);
        }


        public BaseResponse<GetCardResponse, MundipaggErrorsResponse> DeleteCard(string customerId, string cardId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return this.SendRequest<GetCardResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetCardResponse, MundipaggErrorsResponse>> DeleteCardAsync(string customerId, string cardId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return await this.SendRequestAsync<GetCardResponse>(method, endpoint, null);
        }


        public BaseResponse<GetCardResponse, MundipaggErrorsResponse> RenewCard(string customerId, string cardId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/cards/{cardId}/renew";

            return this.SendRequest<GetCardResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetCardResponse, MundipaggErrorsResponse>> RenewCardAsync(string customerId, string cardId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/cards/{cardId}/renew";

            return await this.SendRequestAsync<GetCardResponse>(method, endpoint, null);
        }


        public BaseResponse<GetCardResponse, MundipaggErrorsResponse> UpdateCard(string customerId, string cardId, UpdateCardRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return this.SendRequest<GetCardResponse>(method, endpoint, request);
        }
        public async Task<BaseResponse<GetCardResponse, MundipaggErrorsResponse>> UpdateCardAsync(string customerId, string cardId, UpdateCardRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return await this.SendRequestAsync<GetCardResponse>(method, endpoint, request);
        }

        #endregion

        #region Access Token

        public BaseResponse<GetAccessTokenResponse, MundipaggErrorsResponse> CreateAccessToken(string customerId, CreateAccessTokenRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/access-tokens";

            return this.SendRequest<GetAccessTokenResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetAccessTokenResponse, MundipaggErrorsResponse>> CreateAccessTokenAsync(string customerId, CreateAccessTokenRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/access-tokens";

            return await this.SendRequestAsync<GetAccessTokenResponse>(method, endpoint, request);
        }


        public BaseResponse<GetAccessTokenResponse, MundipaggErrorsResponse> GetAccessToken(string customerId, string tokenId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/access-tokens/{tokenId}";

            return this.SendRequest<GetAccessTokenResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetAccessTokenResponse, MundipaggErrorsResponse>> GetAccessTokenAsync(string customerId, string tokenId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/access-tokens/{tokenId}";

            return await this.SendRequestAsync<GetAccessTokenResponse>(method, endpoint, null);
        }


        public BaseResponse<PagingResponse<GetAccessTokenResponse>, MundipaggErrorsResponse> ListAccessTokens(ListAccessTokensRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/access-tokens";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetAccessTokenResponse>>(method, endpoint, query);
        }


        public async Task<BaseResponse<PagingResponse<GetAccessTokenResponse>, MundipaggErrorsResponse>> ListAccessTokensAsync(ListAccessTokensRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/access-tokens";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<PagingResponse<GetAccessTokenResponse>>(method, endpoint, query);
        }


        public BaseResponse<GetAccessTokenResponse, MundipaggErrorsResponse> DeleteAccessToken(string customerId, string tokenId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/access-tokens/{tokenId}";

            return this.SendRequest<GetAccessTokenResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetAccessTokenResponse, MundipaggErrorsResponse>> DeleteAccessTokenAsync(string customerId, string tokenId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/access-tokens/{tokenId}";

            return await this.SendRequestAsync<GetAccessTokenResponse>(method, endpoint, null);
        }


        public BaseResponse<PagingResponse<GetAccessTokenResponse>, MundipaggErrorsResponse> DeleteAllAccessTokens(string customerId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/access-tokens/";

            return this.SendRequest<PagingResponse<GetAccessTokenResponse>>(method, endpoint, null);
        }

        public async Task<BaseResponse<PagingResponse<GetAccessTokenResponse>, MundipaggErrorsResponse>> DeleteAllAccessTokensAsync(string customerId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/access-tokens/";

            return await this.SendRequestAsync<PagingResponse<GetAccessTokenResponse>>(method, endpoint, null);
        }

        #endregion
    }
}