using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;
using System.Threading.Tasks;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Customer manager
    /// </summary>
    public interface ICustomerResource : IResource
    {
        #region Customer

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetCustomerResponse, MundipaggErrorsResponse> CreateCustomer(CreateCustomerRequest request);

        /// <summary>
        /// Get a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        Task<BaseResponse<GetCustomerResponse, MundipaggErrorsResponse>> CreateCustomerAsync(CreateCustomerRequest request);

        /// <summary>
        /// Get a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse, MundipaggErrorsResponse> GetCustomer(string customerId);

        /// <summary>
        /// Lists all Customers
        /// </summary>
        /// <return>Returns PagingResponse of Models.GetCustomerResponse</Models.ListCustomersResponse> response from the API call</return>
        Task<BaseResponse<GetCustomerResponse, MundipaggErrorsResponse>> GetCustomerAsync(string customerId);

        /// <summary>
        /// Lists all Customers
        /// </summary>
        /// <return>Returns PagingResponse of Models.GetCustomerResponse</Models.ListCustomersResponse> response from the API call</return>
        BaseResponse<PagingResponse<GetCustomerResponse>, MundipaggErrorsResponse> ListCustomers(ListCustomersRequest request);

        /// <summary>
        /// Updates a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for updating a customer</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        Task<BaseResponse<PagingResponse<GetCustomerResponse>, MundipaggErrorsResponse>> ListCustomersAsync(ListCustomersRequest request);

        /// <summary>
        /// Updates a customer
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="request">Required parameter: Request for updating a customer</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse, MundipaggErrorsResponse> UpdateCustomer(string customerId, UpdateCustomerRequest request);

        /// <summary>
        /// Updates the metadata a customer
        /// </summary>
        /// <param name="customerId">Required parameter: The customer id</param>
        /// <param name="request">Required parameter: Request for updating the customer metadata</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        Task<BaseResponse<GetCustomerResponse, MundipaggErrorsResponse>> UpdateCustomerAsync(string customerId, UpdateCustomerRequest request);

        /// <summary>
        /// Updates the metadata a customer
        /// </summary>
        /// <param name="customerId">Required parameter: The customer id</param>
        /// <param name="request">Required parameter: Request for updating the customer metadata</param>
        /// <return>Returns Models.GetCustomerResponse response from the API call</return>
        BaseResponse<GetCustomerResponse, MundipaggErrorsResponse> UpdateCustomerMetadata(string customerId, UpdateMetadataRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseResponse<GetCustomerResponse, MundipaggErrorsResponse>> UpdateCustomerMetadataAsync(string customerId, UpdateMetadataRequest request);

        #endregion

        #region Address

        /// <summary>
        /// Get a customer's address
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAddressResponse, MundipaggErrorsResponse> CreateAddress(string customerId, CreateAddressRequest request);

        /// <summary>
        /// Get a customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        Task<BaseResponse<GetAddressResponse, MundipaggErrorsResponse>> CreateAddressAsync(string customerId, CreateAddressRequest request);

        /// <summary>
        /// Get a customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse, MundipaggErrorsResponse> GetAddress(string customerId, string addressId);

        /// <summary>
        /// Lists all adressess from a customer
        /// </summary>
        Task<BaseResponse<GetAddressResponse, MundipaggErrorsResponse>> GetAddressAsync(string customerId, string addressId);

        /// <summary>
        /// Lists all adressess from a customer
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetAddressResponse>> response from the API call</return>
        /// <return>Returns Task<BaseResponse<PagingResponse<GetAddressResponse>>> response from the API call</return>
        BaseResponse<PagingResponse<GetAddressResponse>, MundipaggErrorsResponse> ListAddresses(ListAddressesRequest request);

        /// <summary>
        /// Delete a Customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        Task<BaseResponse<PagingResponse<GetAddressResponse>, MundipaggErrorsResponse>> ListAddressesAsync(ListAddressesRequest request);

        /// <summary>
        /// Delete a Customer's address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse, MundipaggErrorsResponse> DeleteAddress(string customerId, string addressId);

        /// <summary>
        /// Updates an address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <param name="request">Required parameter: Request for updating an address</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        Task<BaseResponse<GetAddressResponse, MundipaggErrorsResponse>> DeleteAddressAsync(string customerId, string addressId);

        /// <summary>
        /// Updates an address
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="addressId">Required parameter: Address Id</param>
        /// <param name="request">Required parameter: Request for updating an address</param>
        /// <return>Returns Models.GetAddressResponse response from the API call</return>
        BaseResponse<GetAddressResponse, MundipaggErrorsResponse> UpdateAddress(string customerId, string addressId, UpdateAddressRequest request); 
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="addressId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseResponse<GetAddressResponse, MundipaggErrorsResponse>> UpdateAddressAsync(string customerId, string addressId, UpdateAddressRequest request);

        #endregion

        #region Card

        /// <summary>
        /// Get a customer's card
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetCardResponse, MundipaggErrorsResponse> CreateCard(string customerId, CreateCardRequest request);

        /// <summary>
        /// Get a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        Task<BaseResponse<GetCardResponse, MundipaggErrorsResponse>> CreateCardAsync(string customerId, CreateCardRequest request);

        /// <summary>
        /// Get a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, MundipaggErrorsResponse> GetCard(string customerId, string cardId);

        /// <summary>
        /// Lists all cards from a customer
        /// </summary>
        Task<BaseResponse<GetCardResponse, MundipaggErrorsResponse>> GetCardAsync(string customerId, string cardId);

        /// <summary>
        /// Lists all cards from a customer
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetCardResponse>> response from the API call</return>
        /// <return>Returns Task<BaseResponse<PagingResponse<GetCardResponse>>> response from the API call</return>
        BaseResponse<PagingResponse<GetCardResponse>, MundipaggErrorsResponse> ListCards(ListCardsRequest request);

        /// <summary>
        /// Renew a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        Task<BaseResponse<PagingResponse<GetCardResponse>, MundipaggErrorsResponse>> ListCardsAsync(ListCardsRequest request);

        /// <summary>
        /// Renew a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, MundipaggErrorsResponse> RenewCard(string customerId, string cardId);

        /// <summary>
        /// Delete a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        Task<BaseResponse<GetCardResponse, MundipaggErrorsResponse>> RenewCardAsync(string customerId, string cardId);

        /// <summary>
        /// Delete a customer's card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card Id</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, MundipaggErrorsResponse> DeleteCard(string customerId, string cardId);

        /// <summary>
        /// Updates a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        Task<BaseResponse<GetCardResponse, MundipaggErrorsResponse>> DeleteCardAsync(string customerId, string cardId);

        /// <summary>
        /// Updates a card
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="cardId">Required parameter: Card id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <return>Returns Models.GetCardResponse response from the API call</return>
        BaseResponse<GetCardResponse, MundipaggErrorsResponse> UpdateCard(string customerId, string cardId, UpdateCardRequest request);

        /// <summary>
        /// Updates a card
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="cardId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseResponse<GetCardResponse, MundipaggErrorsResponse>> UpdateCardAsync(string customerId, string cardId, UpdateCardRequest request);

        #endregion

        #region Access Token

        /// <summary>
        /// Get a Customer's access token
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetAccessTokenResponse, MundipaggErrorsResponse> CreateAccessToken(string customerId, CreateAccessTokenRequest request);

        /// <summary>
        /// Get a Customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns Models.GetAccessTokenResponse response from the API call</return>
        Task<BaseResponse<GetAccessTokenResponse, MundipaggErrorsResponse>> CreateAccessTokenAsync(string customerId, CreateAccessTokenRequest request);

        /// <summary>
        /// Get a Customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns Models.GetAccessTokenResponse response from the API call</return>
        BaseResponse<GetAccessTokenResponse, MundipaggErrorsResponse> GetAccessToken(string customerId, string tokenId);

        /// <summary>
        /// Lists all access tokens from a customer
        /// </summary>
        Task<BaseResponse<GetAccessTokenResponse, MundipaggErrorsResponse>> GetAccessTokenAsync(string customerId, string tokenId);

        /// <summary>
        /// Lists all access tokens from a customer
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetAccessTokenResponse>> response from the API call</return>
        /// <return>Returns Task<BaseResponse<PagingResponse<GetAccessTokenResponse>>> response from the API call</return>
        BaseResponse<PagingResponse<GetAccessTokenResponse>, MundipaggErrorsResponse> ListAccessTokens(ListAccessTokensRequest request);

        /// <summary>
        /// Delete a customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns Models.GetAccessTokenResponse response from the API call</return>
        Task<BaseResponse<PagingResponse<GetAccessTokenResponse>, MundipaggErrorsResponse>> ListAccessTokensAsync(ListAccessTokensRequest request);

        /// <summary>
        /// Delete a customer's access token
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <param name="tokenId">Required parameter: Token Id</param>
        /// <return>Returns Models.GetAccessTokenResponse response from the API call</return>
        BaseResponse<GetAccessTokenResponse, MundipaggErrorsResponse> DeleteAccessToken(string customerId, string tokenId);

        /// <summary>
        /// Delete a Customer's access tokens
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        Task<BaseResponse<GetAccessTokenResponse, MundipaggErrorsResponse>> DeleteAccessTokenAsync(string customerId, string tokenId);

        /// <summary>
        /// Delete a Customer's access tokens
        /// </summary>
        /// <param name="customerId">Required parameter: Customer Id</param>
        /// <return>Returns BaseResponse<PagingResponse<GetAccessTokenResponse>> response from the API call</return>
        /// <return>Returns Task<BaseResponse<PagingResponse<GetAccessTokenResponse>>> response from the API call</return>
        BaseResponse<PagingResponse<GetAccessTokenResponse>, MundipaggErrorsResponse> DeleteAllAccessTokens(string customerId);

        /// <summary>
        /// Delete a Customer's access tokens
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Task<BaseResponse<PagingResponse<GetAccessTokenResponse>, MundipaggErrorsResponse>> DeleteAllAccessTokensAsync(string customerId);

        #endregion
    }
}