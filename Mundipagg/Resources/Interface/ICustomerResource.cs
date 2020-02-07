using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Customer manager
    /// </summary>
    public interface ICustomerResource : IResource
    {
        #region Customer

        /// <summary>
        /// Creates a new customer
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a customer</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse, ErrorsResponse> CreateCustomer(CreateCustomerRequest request);

        /// <summary>
        /// Get a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse, ErrorsResponse> GetCustomer(string customerId);

        /// <summary>
        /// Lists all Customers
        /// </summary>
        /// <return>Returns Models.ListCustomersResponse response from the API call</return>
        BaseResponse<ListCustomersResponse, ErrorsResponse> ListCustomers(ListCustomersRequest request);

        /// <summary>
        /// Updates a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for updating a customer</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse, ErrorsResponse> UpdateCustomer(string customerId, UpdateCustomerRequest request);

        /// <summary>
        /// Updates the metadata a customer
        /// </summary>
        /// <param name="customerId">Required parameter: The customer id</param>
        /// <param name="request">Required parameter: Request for updating the customer metadata</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse, ErrorsResponse> UpdateCustomerMetadata(string customerId, UpdateMetadataRequest request);

        #endregion

        #region Address

        /// <summary>
        /// Creates a new address for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating an address</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse, ErrorsResponse> CreateAddress(string customerId, CreateAddressRequest request);

        /// <summary>
        /// Get a customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse, ErrorsResponse> GetAddress(string customerId, string addressId);

        /// <summary>
        /// Lists all adressess from a customer
        /// </summary>
        /// <return>Returns Models.ListAddressesResponse response from the API call</return>
        BaseResponse<ListAddressesResponse, ErrorsResponse> ListAddresses(ListAddressesRequest request);

        /// <summary>
        /// Delete a Customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse, ErrorsResponse> DeleteAddress(string customerId, string addressId);

        /// <summary>
        /// Updates an address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <param name="request">Required parameter: Request for updating an address</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse, ErrorsResponse> UpdateAddress(string customerId, string addressId, UpdateAddressRequest request);

        #endregion

        #region Card

        /// <summary>
        /// Creates a new card for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for creating a card</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, ErrorsResponse> CreateCard(string customerId, CreateCardRequest request);

        /// <summary>
        /// Get a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, ErrorsResponse> GetCard(string customerId, string cardId);

        /// <summary>
        /// Lists all cards from a customer
        /// </summary>
        /// <return>Returns Models.ListCardsResponse response from the API call</return>
        BaseResponse<ListCardsResponse, ErrorsResponse> ListCards(ListCardsRequest request);

        /// <summary>
        /// Renew a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, ErrorsResponse> RenewCard(string customerId, string cardId);

        /// <summary>
        /// Delete a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, ErrorsResponse> DeleteCard(string customerId, string cardId);

        /// <summary>
        /// Updates a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, ErrorsResponse> UpdateCard(string customerId, string cardId, UpdateCardRequest request);

        #endregion

        #region Access Token

        /// <summary>
        /// Creates a access token for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating a access token</param>
        /// <return>Returns Models.GetAccessTokenResponse response from the API call</return>
        BaseResponse<GetAccessTokenResponse, ErrorsResponse> CreateAccessToken(string customerId, CreateAccessTokenRequest request);

        /// <summary>
        /// Get a Customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns Models.GetAccessTokenResponse response from the API call</return>
        BaseResponse<GetAccessTokenResponse, ErrorsResponse> GetAccessToken(string customerId, string tokenId);

        /// <summary>
        /// Lists all access tokens from a customer
        /// </summary>
        /// <return>Returns Models.ListAccessTokensResponse response from the API call</return>
        BaseResponse<ListAccessTokensResponse, ErrorsResponse> ListAccessTokens(ListAccessTokensRequest request);

        /// <summary>
        /// Delete a customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns Models.GetAccessTokenResponse response from the API call</return>
        BaseResponse<GetAccessTokenResponse, ErrorsResponse> DeleteAccessToken(string customerId, string tokenId);

        /// <summary>
        /// Delete a Customer's access tokens
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns Models.ListAccessTokensResponse response from the API call</return>
        BaseResponse<ListAccessTokensResponse, ErrorsResponse> DeleteAllAccessTokens(string customerId);

        #endregion
    }
}