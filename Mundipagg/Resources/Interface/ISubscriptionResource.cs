using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;
using System.Threading.Tasks;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Subscription manager
    /// </summary>
    public interface ISubscriptionResource : IResource
    {
        #region Subscription

        /// <summary>
        /// Creates a new subscription
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a subscription</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> CreateSubscription(CreateSubscriptionRequest body);

        /// <summary>
        /// Creates a new subscription
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a subscription</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> CreateSubscriptionAsync(CreateSubscriptionRequest body);

        /// <summary>
        /// Gets a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> GetSubscription(string subscriptionId);

        /// <summary>
        /// Gets a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> GetSubscriptionAsync(string subscriptionId);

        /// <summary>
        /// Lists all subscriptions
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetSubscriptionResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetSubscriptionResponse>, MundipaggErrorsResponse> ListSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Lists all subscriptions
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetSubscriptionResponse>> response from the API call</return>
        Task<BaseResponse<PagingResponse<GetSubscriptionResponse>, MundipaggErrorsResponse>> ListSubscriptionsAsync(ListSubscriptionsRequest request);

        /// <summary>
        /// Cancels a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Optional parameter: Request for cancelling a subscription</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> CancelSubscription(string subscriptionId, CreateCancelSubscriptionRequest request = null);

        /// <summary>
        /// Cancels a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Optional parameter: Request for cancelling a subscription</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> CancelSubscriptionAsync(string subscriptionId, CreateCancelSubscriptionRequest request = null);

        /// <summary>
        /// Updates the metadata from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscrption metadata</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionMetadata(string subscriptionId, UpdateMetadataRequest request);

        /// <summary>
        /// Updates the metadata from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscrption metadata</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionMetadataAsync(string subscriptionId, UpdateMetadataRequest request);

        /// <summary>
        /// Updates the payment method from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating the paymentmethod from a subscription</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionPaymentMethod(string subscriptionId, UpdateSubscriptionPaymentMethodRequest request);

        /// <summary>
        /// Updates the payment method from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating the paymentmethod from a subscription</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionPaymentMethodAsync(string subscriptionId, UpdateSubscriptionPaymentMethodRequest request);

        /// <summary>
        /// Updates the start at date from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscription start date</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionStartAt(string subscriptionId, UpdateSubscriptionStartAtRequest request);

        /// <summary>
        /// Updates the start at date from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscription start date</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionStartAtAsync(string subscriptionId, UpdateSubscriptionStartAtRequest request);

        /// <summary>
        /// Updates the credit card from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionCard(string subscriptionId, UpdateSubscriptionCardRequest request);

        /// <summary>
        /// Updates the credit card from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionCardAsync(string subscriptionId, UpdateSubscriptionCardRequest request);

        /// <summary>
        /// Updates the boleto due days from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="request">Required parameter: Request for updating due date </param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionDueDays(string subscriptionId, UpdateSubscriptionDueDaysRequest request);

        /// <summary>
        /// Updates the boleto due days from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="request">Required parameter: Request for updating due date </param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        /// <return>Returns Task<BaseResponse<GetSubscriptionResponse>> response from the API call</return>
        Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionDueDaysAsync(string subscriptionId, UpdateSubscriptionDueDaysRequest request);

        /// <summary>
        /// Updates subscription minimum price
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="request">Required parameter: Request for updating minimum price</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        /// <return>Returns Task<BaseResponse<GetSubscriptionResponse>> response from the API call</return>
        BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionMiniumPrice(string subscriptionId, UpdateSubscriptionMinimumPriceRequest request);

        /// <summary>
        /// Updates subscription minimum price
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="request">Required parameter: Request for updating minimum price</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        /// <return>Returns Task<BaseResponse<GetSubscriptionResponse>> response from the API call</return>
        Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionMiniumPriceAsync(string subscriptionId, UpdateSubscriptionMinimumPriceRequest request);

        /// <summary>
        /// Updates the billing date from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscription billing date</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        /// <return>Returns Task<BaseResponse<GetSubscriptionResponse>> response from the API call</return>
        BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionBillingDate(string subscriptionId, UpdateSubscriptionBillingDateRequest request);

        /// <summary>
        /// Updates the billing date from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscription billing date</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionBillingDateAsync(string subscriptionId, UpdateSubscriptionBillingDateRequest request);

        /// <summary>
        /// Update cycle end date
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating the end date of the current signature cycle</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse> UpdateCurrentCycleEndDate(string subscriptionId, UpdateCurrentCycleEndDateRequest request);

        /// <summary>
        /// Update cycle end date
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating the end date of the current signature cycle</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse>> UpdateCurrentCycleEndDateAsync(string subscriptionId, UpdateCurrentCycleEndDateRequest request);

        /// <summary>
        /// Update subuscription gateway affiliation
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: </param>
        /// <param name="request">Required parameter: Request for updating a subscription affiliation id</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionAffiliationId(string subscriptionId, UpdateSubscriptionAffiliationIdRequest request);

        /// <summary>
        /// Update subuscription gateway affiliation
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: </param>
        /// <param name="request">Required parameter: Request for updating a subscription affiliation id</param>
        /// <return>Returns BaseResponse<GetSubscriptionResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionAffiliationIdAsync(string subscriptionId, UpdateSubscriptionAffiliationIdRequest request);

        #endregion

        #region Subscription Item

        /// <summary>
        /// Creates a new Subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a subscription item</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse> CreateSubscriptionItem(string subscriptionId, CreateSubscriptionItemRequest request);
        
        /// <summary>
        /// Creates a new Subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a subscription item</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse>> CreateSubscriptionItemAsync(string subscriptionId, CreateSubscriptionItemRequest request);

        /// <summary>
        /// Get Subscription Item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse> GetSubscriptionItem(string subscriptionId, string itemId);

        /// <summary>
        /// Get Subscription Item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse>> GetSubscriptionItemAsync(string subscriptionId, string itemId);

        /// <summary>
        /// Lists Subscription Items
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetSubscriptionItemResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetSubscriptionItemResponse>, MundipaggErrorsResponse> ListSubscriptionItems(ListSubscriptionItemsRequest request);

        /// <summary>
        /// Lists Subscription Items
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetSubscriptionItemResponse>> response from the API call</return>
        Task<BaseResponse<PagingResponse<GetSubscriptionItemResponse>, MundipaggErrorsResponse>> ListSubscriptionItemsAsync(ListSubscriptionItemsRequest request);

        /// <summary>
        /// Updates a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <param name="body">Required parameter: Request for updating a subscription item</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse> UpdateSubscriptionItem(string subscriptionId, string itemId, UpdateSubscriptionItemRequest body);

        /// <summary>
        /// Updates a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <param name="body">Required parameter: Request for updating a subscription item</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse>> UpdateSubscriptionItemAsync(string subscriptionId, string itemId, UpdateSubscriptionItemRequest body);

        /// <summary>
        /// Deletes a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="subscriptionItemId">Required parameter: Subscription item id</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse> DeleteSubscriptionItem(string subscriptionId, string subscriptionItemId);
        
        /// <summary>
        /// Deletes a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="subscriptionItemId">Required parameter: Subscription item id</param>
        /// <return>Returns BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        Task<BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse>> DeleteSubscriptionItemAsync(string subscriptionId, string subscriptionItemId);

        #endregion

        #region Increment

        /// <summary>
        /// Get subscription increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="incrementId">Required parameter: Increment Id</param>
        /// <return>Returns BaseResponse<GetIncrementResponse> response from the API call</return>
        BaseResponse<GetIncrementResponse, MundipaggErrorsResponse> GetIncrement(string subscriptionId, string incrementId);

        /// <summary>
        /// Get subscription increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="incrementId">Required parameter: Increment Id</param>
        /// <return>Returns BaseResponse<GetIncrementResponse> response from the API call</return>
        Task<BaseResponse<GetIncrementResponse, MundipaggErrorsResponse>> GetIncrementAsync(string subscriptionId, string incrementId);

        /// <summary>
        /// Creates a increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a increment</param>
        /// <return>Returns BaseResponse<GetIncrementResponse> response from the API call</return>
        BaseResponse<GetIncrementResponse, MundipaggErrorsResponse> CreateIncrement(string subscriptionId, CreateIncrementRequest request);

        /// <summary>
        /// Creates a increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a increment</param>
        /// <return>Returns BaseResponse<GetIncrementResponse> response from the API call</return>
        Task<BaseResponse<GetIncrementResponse, MundipaggErrorsResponse>> CreateIncrementAsync(string subscriptionId, CreateIncrementRequest request);

        /// <summary>
        /// Lists subscription increments
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetIncrementResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetIncrementResponse>, MundipaggErrorsResponse> ListIncrements(ListIncrementsRequest request);

        /// <summary>
        /// Lists subscription increments
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetIncrementResponse>> response from the API call</return>
        Task<BaseResponse<PagingResponse<GetIncrementResponse>, MundipaggErrorsResponse>> ListIncrementsAsync(ListIncrementsRequest request);

        /// <summary>
        /// Deletes a increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="incrementId">Required parameter: Increment id</param>
        /// <return>Returns BaseResponse<GetIncrementResponse> response from the API call</return>
        BaseResponse<GetIncrementResponse, MundipaggErrorsResponse> DeleteIncrement(string subscriptionId, string incrementId);

        /// <summary>
        /// Deletes a increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="incrementId">Required parameter: Increment id</param>
        /// <return>Returns BaseResponse<GetIncrementResponse> response from the API call</return>
        Task<BaseResponse<GetIncrementResponse, MundipaggErrorsResponse>> DeleteIncrementAsync(string subscriptionId, string incrementId);

        #endregion

        #region Discount

        /// <summary>
        /// Creates a discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a discount</param>
        /// <return>Returns BaseResponse<GetDiscountResponse> response from the API call</return>
        BaseResponse<GetDiscountResponse, MundipaggErrorsResponse> CreateDiscount(string subscriptionId, CreateDiscountRequest request);

        /// <summary>
        /// Creates a discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a discount</param>
        /// <return>Returns BaseResponse<GetDiscountResponse> response from the API call</return>
        Task<BaseResponse<GetDiscountResponse, MundipaggErrorsResponse>> CreateDiscountAsync(string subscriptionId, CreateDiscountRequest request);

        /// <summary>
        /// Deletes a discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="discountId">Required parameter: Discount Id</param>
        /// <return>Returns BaseResponse<GetDiscountResponse> response from the API call</return>
        BaseResponse<GetDiscountResponse, MundipaggErrorsResponse> DeleteDiscount(string subscriptionId, string discountId);

        /// <summary>
        /// Deletes a discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="discountId">Required parameter: Discount Id</param>
        /// <return>Returns BaseResponse<GetDiscountResponse> response from the API call</return>
        Task<BaseResponse<GetDiscountResponse, MundipaggErrorsResponse>> DeleteDiscountAsync(string subscriptionId, string discountId);

        /// <summary>
        /// Get subscription discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="discountId">Required parameter: Example: </param>
        /// <return>Returns BaseResponse<GetDiscountResponse> response from the API call</return>
        BaseResponse<GetDiscountResponse, MundipaggErrorsResponse> GetDiscount(string subscriptionId, string discountId);

        /// <summary>
        /// Get subscription discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="discountId">Required parameter: Example: </param>
        /// <return>Returns BaseResponse<GetDiscountResponse> response from the API call</return>
        Task<BaseResponse<GetDiscountResponse, MundipaggErrorsResponse>> GetDiscountAsync(string subscriptionId, string discountId);

        /// <summary>
        /// Lists subscription discounts
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetDiscountResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetDiscountResponse>, MundipaggErrorsResponse> ListDiscounts(ListDiscountsRequest request);

        /// <summary>
        /// Lists subscription discounts
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetDiscountResponse>> response from the API call</return>
        Task<BaseResponse<PagingResponse<GetDiscountResponse>, MundipaggErrorsResponse>> ListDiscountsAsync(ListDiscountsRequest request);

        #endregion

        #region Usage

        /// <summary>
        /// Creates usage
        /// </summary>
        /// <param name="subscriptionId"></param>
        /// <param name="itemId"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        BaseResponse<GetUsageResponse, MundipaggErrorsResponse> CreateUsage(string subscriptionId, string itemId, CreateUsageRequest body = null, string idempotencyKey = null);

        /// <summary>
        /// Creates usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="itemId">Required parameter: The subscription item id</param>
        /// <param name="usageId">Required parameter: The usage id</param>
        Task<BaseResponse<GetUsageResponse, MundipaggErrorsResponse>> CreateUsageAsync(string subscriptionId, string itemId, CreateUsageRequest body = null, string idempotencyKey = null);

        /// <summary>
        /// Deletes a usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="itemId">Required parameter: The subscription item id</param>
        /// <param name="usageId">Required parameter: The usage id</param>
        /// <return>Returns BaseResponse<GetUsageResponse> response from the API call</return>
        BaseResponse<GetUsageResponse, MundipaggErrorsResponse> DeleteUsage(string subscriptionId, string itemId, string usageId);

        /// <summary>
        /// Deletes a usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="itemId">Required parameter: The subscription item id</param>
        /// <param name="usageId">Required parameter: The usage id</param>
        /// <return>Returns BaseResponse<GetUsageResponse> response from the API call</return>
        Task<BaseResponse<GetUsageResponse, MundipaggErrorsResponse>> DeleteUsageAsync(string subscriptionId, string itemId, string usageId);

        /// <summary>
        /// Get current usage details
        /// </summary>
        /// <return>Returns BaseResponse<GetUsagesDetailsResponse> response from the API call</return>
        BaseResponse<GetUsagesDetailsResponse, MundipaggErrorsResponse> GetCurrentUsages(ListUsageDetailsRequest request);

        /// <summary>
        /// Get current usage details
        /// </summary>
        /// <return>Returns BaseResponse<GetUsagesDetailsResponse> response from the API call</return>
        Task<BaseResponse<GetUsagesDetailsResponse, MundipaggErrorsResponse>> GetCurrentUsagesAsync(ListUsageDetailsRequest request);

        /// <summary>
        /// Lists all usages from a subscription item
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetUsageResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetUsageResponse>, MundipaggErrorsResponse> ListUsages(ListUsagesRequest request);

        /// <summary>
        /// Lists all usages from a subscription item
        /// </summary>
        /// <return>Returns BaseResponse<PagingResponse<GetUsageResponse>> response from the API call</return>
        Task<BaseResponse<PagingResponse<GetUsageResponse>, MundipaggErrorsResponse>> ListUsagesAsync(ListUsagesRequest request);

        #endregion
    }
}