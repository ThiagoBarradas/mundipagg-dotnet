using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using System.Net.Http;

namespace Mundipagg.Resources
{
    /// <summary>
    /// Customer manager
    /// </summary>
    public class CustomerResource : BaseResource, ICustomerResource
    {
        #region Public Constructors

        /// <summary>
        /// Creates a new customer manager
        /// </summary>
        /// <param name="configuration">Mundipagg Api configuration</param>
        public CustomerResource(Configuration configuration) : base(configuration) { }

        #endregion Public Constructors

        #region Public Methods

        public BaseResponse<GetAccessTokenResponse> CreateAccessToken(string customerId, CreateAccessTokenRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/access-tokens";

            return this.HttpClientUtil.SendRequest<GetAccessTokenResponse>(method, endpoint, request);
        }

        public BaseResponse<GetAddressResponse> CreateAddress(string customerId, CreateAddressRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/addresses";

            return this.HttpClientUtil.SendRequest<GetAddressResponse>(method, endpoint, request);
        }

        public BaseResponse<GetCardResponse> CreateCard(string customerId, CreateCardRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/cards";

            return this.HttpClientUtil.SendRequest<GetCardResponse>(method, endpoint, request);
        }

        public BaseResponse<GetCustomerResponse> CreateCustomer(CreateCustomerRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers";

            return this.HttpClientUtil.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }

        public BaseResponse<GetAccessTokenResponse> DeleteAccessToken(string customerId, string tokenId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/access-tokens/{tokenId}";

            return this.HttpClientUtil.SendRequest<GetAccessTokenResponse>(method, endpoint, null);
        }

        public BaseResponse<ListAccessTokensResponse> DeleteAccessTokens(string customerId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/access-tokens/";

            return this.HttpClientUtil.SendRequest<ListAccessTokensResponse>(method, endpoint, null);
        }

        public BaseResponse<GetAddressResponse> DeleteAddress(string customerId, string addressId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return this.HttpClientUtil.SendRequest<GetAddressResponse>(method, endpoint, null);
        }

        public BaseResponse<GetCardResponse> DeleteCard(string customerId, string cardId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return this.HttpClientUtil.SendRequest<GetCardResponse>(method, endpoint, null);
        }

        public BaseResponse<GetAccessTokenResponse> GetAccessToken(string customerId, string tokenId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/access-tokens/{tokenId}";

            return this.HttpClientUtil.SendRequest<GetAccessTokenResponse>(method, endpoint, null);
        }

        public BaseResponse<ListAccessTokensResponse> GetAccessTokens(ListAccessTokensRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/access-tokens";
            var query = request.ToDictionary();

            return this.HttpClientUtil.SendRequest<ListAccessTokensResponse>(method, endpoint, query);
        }

        public BaseResponse<GetAddressResponse> GetAddress(string customerId, string addressId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return this.HttpClientUtil.SendRequest<GetAddressResponse>(method, endpoint, null);
        }

        public BaseResponse<ListAddressesResponse> GetAddresses(ListAddressesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/addresses";
            var query = request.ToDictionary();

            return this.HttpClientUtil.SendRequest<ListAddressesResponse>(method, endpoint, query);
        }

        public BaseResponse<GetCardResponse> GetCard(string customerId, string cardId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return this.HttpClientUtil.SendRequest<GetCardResponse>(method, endpoint, null);
        }

        public BaseResponse<ListCardsResponse> GetCards(ListCardsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/cards";
            var query = request.ToDictionary();

            return this.HttpClientUtil.SendRequest<ListCardsResponse>(method, endpoint, query);
        }

        public BaseResponse<GetCustomerResponse> GetCustomer(string customerId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}";

            return this.HttpClientUtil.SendRequest<GetCustomerResponse>(method, endpoint, null);
        }

        public BaseResponse<ListCustomersResponse> GetCustomers(ListCustomersRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers";
            var query = request.ToDictionary();

            return this.HttpClientUtil.SendRequest<ListCustomersResponse>(method, endpoint, query);
        }

        public BaseResponse<GetCardResponse> RenewCard(string customerId, string cardId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/cards/{cardId}/renew";

            return this.HttpClientUtil.SendRequest<GetCardResponse>(method, endpoint, null);
        }

        public BaseResponse<GetAddressResponse> UpdateAddress(string customerId, string addressId, UpdateAddressRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return this.HttpClientUtil.SendRequest<GetAddressResponse>(method, endpoint, request);
        }

        public BaseResponse<GetCardResponse> UpdateCard(string customerId, string cardId, UpdateCardRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return this.HttpClientUtil.SendRequest<GetCardResponse>(method, endpoint, request);
        }

        public BaseResponse<GetCustomerResponse> UpdateCustomer(string customerId, UpdateCustomerRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}";

            return this.HttpClientUtil.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }

        public BaseResponse<GetCustomerResponse> UpdateCustomerMetadata(string customerId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/customers/{customerId}/metadata";

            return this.HttpClientUtil.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }

        #endregion Public Methods
    }
}