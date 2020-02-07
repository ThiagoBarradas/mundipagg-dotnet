using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace Mundipagg.Resources
{
    public class CustomerResource : BaseResource, ICustomerResource
    {
        public CustomerResource(Configuration configuration) : base(configuration) { }

        #region Customer

        public BaseResponse<GetCustomerResponse, ErrorsResponse> CreateCustomer(CreateCustomerRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers";

            return this.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }

        public BaseResponse<GetCustomerResponse, ErrorsResponse> GetCustomer(string customerId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}";

            return this.SendRequest<GetCustomerResponse>(method, endpoint, null);
        }

        public BaseResponse<ListCustomersResponse, ErrorsResponse> ListCustomers(ListCustomersRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers";
            var query = request.ToDictionary();

            return this.SendRequest<ListCustomersResponse>(method, endpoint, query);
        }

        public BaseResponse<GetCustomerResponse, ErrorsResponse> UpdateCustomer(string customerId, UpdateCustomerRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}";

            return this.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }

        public BaseResponse<GetCustomerResponse, ErrorsResponse> UpdateCustomerMetadata(string customerId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/customers/{customerId}/metadata";

            return this.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }

        #endregion

        #region Address

        public BaseResponse<GetAddressResponse, ErrorsResponse> CreateAddress(string customerId, CreateAddressRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/addresses";

            return this.SendRequest<GetAddressResponse>(method, endpoint, request);
        }

        public BaseResponse<GetAddressResponse, ErrorsResponse> DeleteAddress(string customerId, string addressId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return this.SendRequest<GetAddressResponse>(method, endpoint, null);
        }

        public BaseResponse<GetAddressResponse, ErrorsResponse> GetAddress(string customerId, string addressId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return this.SendRequest<GetAddressResponse>(method, endpoint, null);
        }

        public BaseResponse<ListAddressesResponse, ErrorsResponse> ListAddresses(ListAddressesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/addresses";
            var query = request.ToDictionary();

            return this.SendRequest<ListAddressesResponse>(method, endpoint, query);
        }

        public BaseResponse<GetAddressResponse, ErrorsResponse> UpdateAddress(string customerId, string addressId, UpdateAddressRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}/addresses/{addressId}";

            return this.SendRequest<GetAddressResponse>(method, endpoint, request);
        }

        #endregion

        #region Card

        public BaseResponse<GetCardResponse, ErrorsResponse> CreateCard(string customerId, CreateCardRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/cards";

            return this.SendRequest<GetCardResponse>(method, endpoint, request);
        }

        public BaseResponse<GetCardResponse, ErrorsResponse> GetCard(string customerId, string cardId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return this.SendRequest<GetCardResponse>(method, endpoint, null);
        }

        public BaseResponse<ListCardsResponse, ErrorsResponse> ListCards(ListCardsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/cards";
            var query = request.ToDictionary();

            return this.SendRequest<ListCardsResponse>(method, endpoint, query);
        }

        public BaseResponse<GetCardResponse, ErrorsResponse> DeleteCard(string customerId, string cardId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return this.SendRequest<GetCardResponse>(method, endpoint, null);
        }

        public BaseResponse<GetCardResponse, ErrorsResponse> RenewCard(string customerId, string cardId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/cards/{cardId}/renew";

            return this.SendRequest<GetCardResponse>(method, endpoint, null);
        }

        public BaseResponse<GetCardResponse, ErrorsResponse> UpdateCard(string customerId, string cardId, UpdateCardRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/customers/{customerId}/cards/{cardId}";

            return this.SendRequest<GetCardResponse>(method, endpoint, request);
        }

        #endregion

        #region Access Token

        public BaseResponse<GetAccessTokenResponse, ErrorsResponse> CreateAccessToken(string customerId, CreateAccessTokenRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/customers/{customerId}/access-tokens";

            return this.SendRequest<GetAccessTokenResponse>(method, endpoint, request);
        }

        public BaseResponse<GetAccessTokenResponse, ErrorsResponse> GetAccessToken(string customerId, string tokenId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{customerId}/access-tokens/{tokenId}";

            return this.SendRequest<GetAccessTokenResponse>(method, endpoint, null);
        }

        public BaseResponse<ListAccessTokensResponse, ErrorsResponse> ListAccessTokens(ListAccessTokensRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/customers/{request.CustomerId}/access-tokens";
            var query = request.ToDictionary();

            return this.SendRequest<ListAccessTokensResponse>(method, endpoint, query);
        }

        public BaseResponse<GetAccessTokenResponse, ErrorsResponse> DeleteAccessToken(string customerId, string tokenId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/access-tokens/{tokenId}";

            return this.SendRequest<GetAccessTokenResponse>(method, endpoint, null);
        }

        public BaseResponse<ListAccessTokensResponse, ErrorsResponse> DeleteAllAccessTokens(string customerId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/customers/{customerId}/access-tokens/";

            return this.SendRequest<ListAccessTokensResponse>(method, endpoint, null);
        }

        #endregion
    }
}