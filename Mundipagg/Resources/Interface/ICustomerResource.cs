using Mundipagg.Models.Request;
using Mundipagg.Models.Response;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Customer manager
    /// </summary>
    public interface ICustomerResource
    {
        /// <summary>
        /// Creates a access token for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating a access token</param>
        /// <return>Returns the Models.GetAccessTokenResponse response from the API call</return>
        BaseResponse<GetAccessTokenResponse> CreateAccessToken(string customerId, CreateAccessTokenRequest request);

        /// <summary>
        /// Creates a new address for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="request">Required parameter: Request for creating an address</param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse> CreateAddress(string customerId, CreateAddressRequest request);

        /// <summary>
        /// Creates a new card for a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for creating a card</param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse> CreateCard(string customerId, CreateCardRequest request);

        /// <summary>
        /// Creates a new customer
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a customer</param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse> CreateCustomer(CreateCustomerRequest request);

        /// <summary>
        /// Delete a customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns the Models.GetAccessTokenResponse response from the API call</return>
        BaseResponse<GetAccessTokenResponse> DeleteAccessToken(string customerId, string tokenId);

        /// <summary>
        /// Delete a Customer's access tokens
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns the Models.ListAccessTokensResponse response from the API call</return>
        BaseResponse<ListAccessTokensResponse> DeleteAccessTokens(string customerId);

        /// <summary>
        /// Delete a Customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse> DeleteAddress(string customerId, string addressId);

        /// <summary>
        /// Delete a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse> DeleteCard(string customerId, string cardId);

        /// <summary>
        /// Get a Customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns the Models.GetAccessTokenResponse response from the API call</return>
        BaseResponse<GetAccessTokenResponse> GetAccessToken(string customerId, string tokenId);

        /// <summary>
        /// Get all access tokens from a customer
        /// </summary>
        /// <return>Returns the Models.ListAccessTokensResponse response from the API call</return>
        BaseResponse<ListAccessTokensResponse> GetAccessTokens(ListAccessTokensRequest request);

        /// <summary>
        /// Get a customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse> GetAddress(string customerId, string addressId);

        /// <summary>
        /// Gets all adressess from a customer
        /// </summary>
        /// <return>Returns the Models.ListAddressesResponse response from the API call</return>
        BaseResponse<ListAddressesResponse> GetAddresses(ListAddressesRequest request);

        /// <summary>
        /// Get a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse> GetCard(string customerId, string cardId);

        /// <summary>
        /// Get all cards from a customer
        /// </summary>
        /// <return>Returns the Models.ListCardsResponse response from the API call</return>
        BaseResponse<ListCardsResponse> GetCards(ListCardsRequest request);

        /// <summary>
        /// Get a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse> GetCustomer(string customerId);

        /// <summary>
        /// Get all Customers
        /// </summary>
        /// <return>Returns the Models.ListCustomersResponse response from the API call</return>
        BaseResponse<ListCustomersResponse> GetCustomers(ListCustomersRequest request);

        /// <summary>
        /// Renew a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse> RenewCard(string customerId, string cardId);

        /// <summary>
        /// Updates an address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <param name="request">Required parameter: Request for updating an address</param>
        /// <return>Returns the Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse> UpdateAddress(string customerId, string addressId, UpdateAddressRequest request);

        /// <summary>
        /// Updates a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <return>Returns the Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse> UpdateCard(string customerId, string cardId, UpdateCardRequest request);

        /// <summary>
        /// Updates a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for updating a customer</param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse> UpdateCustomer(string customerId, UpdateCustomerRequest request);

        /// <summary>
        /// Updates the metadata a customer
        /// </summary>
        /// <param name="customerId">Required parameter: The customer id</param>
        /// <param name="request">Required parameter: Request for updating the customer metadata</param>
        /// <return>Returns the Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse> UpdateCustomerMetadata(string customerId, UpdateMetadataRequest request);
    }
}