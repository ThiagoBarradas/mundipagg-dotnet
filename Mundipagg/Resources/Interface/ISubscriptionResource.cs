using Mundipagg.Models.Request;
using Mundipagg.Models.Response;

namespace Mundipagg.Resources.Interface
{
    public interface ISubscriptionResource : IResource
    {
        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription Id</param>
        /// <param name="incrementId">Required parameter: The increment Id</param>
        /// <return>Returns the BaseResponse<GetIncrementResponse> response from the API call</return>
        BaseResponse<GetIncrementResponse> GetIncrementById(string subscriptionId, string incrementId);

        /// <summary>
        /// Updates the start at date from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscription start date</param>
        /// <return>Returns the BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionStartAt(string subscriptionId, UpdateSubscriptionStartAtRequest request);

        /// <summary>
        /// Updates the credit card from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating a card</param>
        /// <return>Returns the BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionCard(string subscriptionId, UpdateSubscriptionCardRequest request);

        /// <summary>
        /// Updates a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <param name="body">Required parameter: Request for updating a subscription item</param>
        /// <return>Returns the BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse> UpdateSubscriptionItem(string subscriptionId, string itemId, UpdateSubscriptionItemRequest body);

        /// <summary>
        /// Creates a usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <param name="body">Required parameter: Request for creating a usage</param>
        /// <return>Returns the BaseResponse<GetUsageResponse> response from the API call</return>
        BaseResponse<GetUsageResponse> CreateUsage(string subscriptionId, string itemId, CreateUsageRequest body);

        /// <summary>
        /// Gets a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <return>Returns the BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> GetSubscription(string subscriptionId);

        /// <summary>
        /// Updates the payment method from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for updating the paymentmethod from a subscription</param>
        /// <return>Returns the BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionPaymentMethod(string subscriptionId, UpdateSubscriptionPaymentMethodRequest request);

        /// <summary>
        /// Creates a new subscription
        /// </summary>
        /// <param name="body">Required parameter: Request for creating a subscription</param>
        /// <return>Returns the BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> CreateSubscription(CreateSubscriptionRequest body);

        /// <summary>
        /// Creates a new Subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a subscription item</param>
        /// <return>Returns the BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse> CreateSubscriptionItem(string subscriptionId, CreateSubscriptionItemRequest request);

        /// <summary>
        /// Creates a discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a discount</param>
        /// <return>Returns the BaseResponse<GetDiscountResponse> response from the API call</return>
        BaseResponse<GetDiscountResponse> CreateDiscount(string subscriptionId, CreateDiscountRequest request);

        /// <summary>
        /// Get Subscription Item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <return>Returns the BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse> GetSubscriptionItem(string subscriptionId, string itemId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: </param>
        /// <param name="request">Required parameter: Request for updating a subscription affiliation id</param>
        /// <return>Returns the BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionAffiliationId(string subscriptionId, UpdateSubscriptionAffiliationIdRequest request);

        /// <summary>
        /// Create Usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="itemId">Required parameter: Item id</param>
        /// <return>Returns the BaseResponse<GetUsageResponse> response from the API call</return>
        BaseResponse<GetUsageResponse> CreateAnUsage(string subscriptionId, string itemId);

        /// <summary>
        /// Gets all subscriptions
        /// </summary>
        /// <return>Returns the BaseResponse<ListSubscriptionsResponse> response from the API call</return>
        BaseResponse<ListSubscriptionsResponse> GetSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Updates the metadata from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscrption metadata</param>
        /// <return>Returns the BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionMetadata(string subscriptionId, UpdateMetadataRequest request);

        /// <summary>
        /// Deletes a subscription item
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="subscriptionItemId">Required parameter: Subscription item id</param>
        /// <return>Returns the BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse> DeleteSubscriptionItem(string subscriptionId, string subscriptionItemId);

        /// <summary>
        /// Deletes a usage
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="itemId">Required parameter: The subscription item id</param>
        /// <param name="usageId">Required parameter: The usage id</param>
        /// <return>Returns the BaseResponse<GetUsageResponse> response from the API call</return>
        BaseResponse<GetUsageResponse> DeleteUsage(string subscriptionId, string itemId, string usageId);

        /// <summary>
        /// Deletes a discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="discountId">Required parameter: Discount Id</param>
        /// <return>Returns the BaseResponse<GetDiscountResponse> response from the API call</return>
        BaseResponse<GetDiscountResponse> DeleteDiscount(string subscriptionId, string discountId);

        /// <summary>
        /// Cancels a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Optional parameter: Request for cancelling a subscription</param>
        /// <return>Returns the BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> CancelSubscription(string subscriptionId, CreateCancelSubscriptionRequest request = null);

        /// <summary>
        /// Get subscription discount
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="discountId">Required parameter: Example: </param>
        /// <return>Returns the BaseResponse<GetDiscountResponse> response from the API call</return>
        BaseResponse<GetDiscountResponse> GetDiscountById(string subscriptionId, string discountId);

        /// <summary>
        /// Get subscription discounts
        /// </summary>
        /// <return>Returns the BaseResponse<ListDiscountsResponse> response from the API call</return>
        BaseResponse<ListDiscountsResponse> GetDiscounts(ListDiscountsRequest request);

        /// <summary>
        /// Creates a increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="request">Required parameter: Request for creating a increment</param>
        /// <return>Returns the BaseResponse<GetIncrementResponse> response from the API call</return>
        BaseResponse<GetIncrementResponse> CreateIncrement(string subscriptionId, CreateIncrementRequest request);

        /// <summary>
        /// Get subscription increments
        /// </summary>
        /// <return>Returns the BaseResponse<ListIncrementsResponse> response from the API call</return>
        BaseResponse<ListIncrementsResponse> GetIncrements(ListIncrementsRequest request);

        /// <summary>
        /// Deletes a increment
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription id</param>
        /// <param name="incrementId">Required parameter: Increment id</param>
        /// <return>Returns the BaseResponse<GetIncrementResponse> response from the API call</return>
        BaseResponse<GetIncrementResponse> DeleteIncrement(string subscriptionId, string incrementId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <return>Returns the BaseResponse<GetUsagesDetailsResponse> response from the API call</return>
        BaseResponse<GetUsagesDetailsResponse> GetUsagesDetails(ListUsageDetailsRequest request);

        /// <summary>
        /// Lists all usages from a subscription item
        /// </summary>
        /// <return>Returns the BaseResponse<ListUsagesResponse> response from the API call</return>
        BaseResponse<ListUsagesResponse> GetUsages(ListUsagesRequest request);

        /// <summary>
        /// Get Subscription Items
        /// </summary>
        /// <return>Returns the BaseResponse<ListSubscriptionItemsResponse> response from the API call</return>
        BaseResponse<ListSubscriptionItemsResponse> GetSubscriptionItems(ListSubscriptionItemsRequest request);

        /// <summary>
        /// Updates the boleto due days from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="request">Required parameter: Example: </param>
        /// <return>Returns the BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionDueDays(string subscriptionId, UpdateSubscriptionDueDaysRequest request);

        /// <summary>
        /// Atualização do valor mínimo da assinatura
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="request">Required parameter: Request da requisição com o valor mínimo que será configurado</param>
        /// <return>Returns the BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionMiniumPrice(string subscriptionId, UpdateSubscriptionMinimumPriceRequest request);

        /// <summary>
        /// Updates the billing date from a subscription
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The subscription id</param>
        /// <param name="request">Required parameter: Request for updating the subscription billing date</param>
        /// <return>Returns the BaseResponse<GetSubscriptionResponse> response from the API call</return>
        BaseResponse<GetSubscriptionResponse> UpdateSubscriptionBillingDate(string subscriptionId, UpdateSubscriptionBillingDateRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Example: </param>
        /// <param name="request">Required parameter: Request for updating the end date of the current signature cycle</param>
        /// <return>Returns the BaseResponse<GetSubscriptionItemResponse> response from the API call</return>
        BaseResponse<GetSubscriptionItemResponse> UpdateCurrentCycleEndDate(string subscriptionId, UpdateCurrentCycleEndDateRequest request);
    }
}