using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace Mundipagg.Resources
{
    public class SubscriptionResource : BaseResource, ISubscriptionResource
    {
        public SubscriptionResource(Configuration configuration) : base(configuration) { }

        #region Subscription

        public BaseResponse<GetSubscriptionResponse> GetSubscription(string subscriptionId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, null);
        }

        public BaseResponse<GetSubscriptionResponse> CreateSubscription(CreateSubscriptionRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<ListSubscriptionsResponse> ListSubscriptions(ListSubscriptionsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions";
            var query = request.ToDictionary();

            return this.SendRequest<ListSubscriptionsResponse>(method, endpoint, null, query);
        }

        public BaseResponse<GetSubscriptionResponse> CancelSubscription(string subscriptionId, CreateCancelSubscriptionRequest request = null)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse> UpdateSubscriptionMetadata(string subscriptionId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/metadata";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse> UpdateSubscriptionMiniumPrice(string subscriptionId, UpdateSubscriptionMinimumPriceRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/minimum_price";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse> UpdateSubscriptionPaymentMethod(string subscriptionId, UpdateSubscriptionPaymentMethodRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/payment-method";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse> UpdateSubscriptionStartAt(string subscriptionId, UpdateSubscriptionStartAtRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/start-at";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        #endregion

        #region Subscription Item
        
        public BaseResponse<GetSubscriptionItemResponse> GetSubscriptionItem(string subscriptionId, string itemId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, null);
        }

        public BaseResponse<GetSubscriptionItemResponse> CreateSubscriptionItem(string subscriptionId, CreateSubscriptionItemRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/items";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionItemResponse> DeleteSubscriptionItem(string subscriptionId, string subscriptionItemId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{subscriptionItemId}";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, null);
        }

        public BaseResponse<ListSubscriptionItemsResponse> ListSubscriptionItems(ListSubscriptionItemsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/items";
            var query = request.ToDictionary();

            return this.SendRequest<ListSubscriptionItemsResponse>(method, endpoint, null, query);
        }

        public BaseResponse<GetSubscriptionItemResponse> UpdateSubscriptionItem(string subscriptionId, string itemId, UpdateSubscriptionItemRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionItemResponse> UpdateCurrentCycleEndDate(string subscriptionId, UpdateCurrentCycleEndDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/cycle-end-date";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse> UpdateSubscriptionAffiliationId(string subscriptionId, UpdateSubscriptionAffiliationIdRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/gateway-affiliation-id";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse> UpdateSubscriptionBillingDate(string subscriptionId, UpdateSubscriptionBillingDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/billing-date";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse> UpdateSubscriptionCard(string subscriptionId, UpdateSubscriptionCardRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/card";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse> UpdateSubscriptionDueDays(string subscriptionId, UpdateSubscriptionDueDaysRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/boleto-due-days";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        #endregion

        #region Discount

        public BaseResponse<GetDiscountResponse> CreateDiscount(string subscriptionId, CreateDiscountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts";

            return this.SendRequest<GetDiscountResponse>(method, endpoint, request);
        }

        public BaseResponse<GetDiscountResponse> GetDiscount(string subscriptionId, string discountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts/{discountId}";

            return this.SendRequest<GetDiscountResponse>(method, endpoint, null);
        }

        public BaseResponse<GetDiscountResponse> DeleteDiscount(string subscriptionId, string discountId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts/{discountId}";

            return this.SendRequest<GetDiscountResponse>(method, endpoint, null);
        }

        public BaseResponse<ListDiscountsResponse> ListDiscounts(ListDiscountsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/discounts/";
            var query = request.ToDictionary();

            return this.SendRequest<ListDiscountsResponse>(method, endpoint, null, query);
        }

        #endregion

        #region Increment

        public BaseResponse<GetIncrementResponse> GetIncrement(string subscriptionId, string incrementId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/increments/{incrementId}";

            return this.SendRequest<GetIncrementResponse>(method, endpoint, null);
        }

        public BaseResponse<GetIncrementResponse> CreateIncrement(string subscriptionId, CreateIncrementRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/increments";

            return this.SendRequest<GetIncrementResponse>(method, endpoint, request);
        }

        public BaseResponse<GetIncrementResponse> DeleteIncrement(string subscriptionId, string incrementId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/increments/{incrementId}";

            return this.SendRequest<GetIncrementResponse>(method, endpoint, null);
        }

        public BaseResponse<ListIncrementsResponse> ListIncrements(ListIncrementsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/increments/";
            var query = request.ToDictionary();

            return this.SendRequest<ListIncrementsResponse>(method, endpoint, null, query);
        }

        #endregion

        #region Usage

        public BaseResponse<GetUsageResponse> CreateUsage(string subscriptionId, string itemId, CreateUsageRequest request = null)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}/usages";

            return this.SendRequest<GetUsageResponse>(method, endpoint, request);
        }

        public BaseResponse<GetUsagesDetailsResponse> GetCurrentUsages(ListUsageDetailsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/usages-details/";
            var query = request.ToDictionary();

            return this.SendRequest<GetUsagesDetailsResponse>(method, endpoint, null, query);
        }

        public BaseResponse<ListUsagesResponse> ListUsages(ListUsagesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/items/{request.ItemId}/usages";
            var query = request.ToDictionary();

            return this.SendRequest<ListUsagesResponse>(method, endpoint, null, query);
        }

        public BaseResponse<GetUsageResponse> DeleteUsage(string subscriptionId, string itemId, string usageId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}/usages/{usageId}";

            return this.SendRequest<GetUsageResponse>(method, endpoint, null);
        }

        #endregion
    }
}