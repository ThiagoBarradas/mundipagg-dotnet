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

        public BaseResponse<GetSubscriptionResponse, ErrorsResponse> GetSubscription(string subscriptionId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, null);
        }

        public BaseResponse<GetSubscriptionResponse, ErrorsResponse> CreateSubscription(CreateSubscriptionRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<ListSubscriptionsResponse, ErrorsResponse> ListSubscriptions(ListSubscriptionsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions";
            var query = request.ToDictionary();

            return this.SendRequest<ListSubscriptionsResponse>(method, endpoint, null, query);
        }

        public BaseResponse<GetSubscriptionResponse, ErrorsResponse> CancelSubscription(string subscriptionId, CreateCancelSubscriptionRequest request = null)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, ErrorsResponse> UpdateSubscriptionMetadata(string subscriptionId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/metadata";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, ErrorsResponse> UpdateSubscriptionMiniumPrice(string subscriptionId, UpdateSubscriptionMinimumPriceRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/minimum_price";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, ErrorsResponse> UpdateSubscriptionPaymentMethod(string subscriptionId, UpdateSubscriptionPaymentMethodRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/payment-method";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, ErrorsResponse> UpdateSubscriptionStartAt(string subscriptionId, UpdateSubscriptionStartAtRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/start-at";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        #endregion

        #region Subscription Item
        
        public BaseResponse<GetSubscriptionItemResponse, ErrorsResponse> GetSubscriptionItem(string subscriptionId, string itemId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, null);
        }

        public BaseResponse<GetSubscriptionItemResponse, ErrorsResponse> CreateSubscriptionItem(string subscriptionId, CreateSubscriptionItemRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/items";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionItemResponse, ErrorsResponse> DeleteSubscriptionItem(string subscriptionId, string subscriptionItemId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{subscriptionItemId}";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, null);
        }

        public BaseResponse<ListSubscriptionItemsResponse, ErrorsResponse> ListSubscriptionItems(ListSubscriptionItemsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/items";
            var query = request.ToDictionary();

            return this.SendRequest<ListSubscriptionItemsResponse>(method, endpoint, null, query);
        }

        public BaseResponse<GetSubscriptionItemResponse, ErrorsResponse> UpdateSubscriptionItem(string subscriptionId, string itemId, UpdateSubscriptionItemRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionItemResponse, ErrorsResponse> UpdateCurrentCycleEndDate(string subscriptionId, UpdateCurrentCycleEndDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/cycle-end-date";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, ErrorsResponse> UpdateSubscriptionAffiliationId(string subscriptionId, UpdateSubscriptionAffiliationIdRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/gateway-affiliation-id";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, ErrorsResponse> UpdateSubscriptionBillingDate(string subscriptionId, UpdateSubscriptionBillingDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/billing-date";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, ErrorsResponse> UpdateSubscriptionCard(string subscriptionId, UpdateSubscriptionCardRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/card";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public BaseResponse<GetSubscriptionResponse, ErrorsResponse> UpdateSubscriptionDueDays(string subscriptionId, UpdateSubscriptionDueDaysRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/boleto-due-days";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        #endregion

        #region Discount

        public BaseResponse<GetDiscountResponse, ErrorsResponse> CreateDiscount(string subscriptionId, CreateDiscountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts";

            return this.SendRequest<GetDiscountResponse>(method, endpoint, request);
        }

        public BaseResponse<GetDiscountResponse, ErrorsResponse> GetDiscount(string subscriptionId, string discountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts/{discountId}";

            return this.SendRequest<GetDiscountResponse>(method, endpoint, null);
        }

        public BaseResponse<GetDiscountResponse, ErrorsResponse> DeleteDiscount(string subscriptionId, string discountId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts/{discountId}";

            return this.SendRequest<GetDiscountResponse>(method, endpoint, null);
        }

        public BaseResponse<ListDiscountsResponse, ErrorsResponse> ListDiscounts(ListDiscountsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/discounts/";
            var query = request.ToDictionary();

            return this.SendRequest<ListDiscountsResponse>(method, endpoint, null, query);
        }

        #endregion

        #region Increment

        public BaseResponse<GetIncrementResponse, ErrorsResponse> GetIncrement(string subscriptionId, string incrementId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/increments/{incrementId}";

            return this.SendRequest<GetIncrementResponse>(method, endpoint, null);
        }

        public BaseResponse<GetIncrementResponse, ErrorsResponse> CreateIncrement(string subscriptionId, CreateIncrementRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/increments";

            return this.SendRequest<GetIncrementResponse>(method, endpoint, request);
        }

        public BaseResponse<GetIncrementResponse, ErrorsResponse> DeleteIncrement(string subscriptionId, string incrementId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/increments/{incrementId}";

            return this.SendRequest<GetIncrementResponse>(method, endpoint, null);
        }

        public BaseResponse<ListIncrementsResponse, ErrorsResponse> ListIncrements(ListIncrementsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/increments/";
            var query = request.ToDictionary();

            return this.SendRequest<ListIncrementsResponse>(method, endpoint, null, query);
        }

        #endregion

        #region Usage

        public BaseResponse<GetUsageResponse, ErrorsResponse> CreateUsage(string subscriptionId, string itemId, CreateUsageRequest request = null)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}/usages";

            return this.SendRequest<GetUsageResponse>(method, endpoint, request);
        }

        public BaseResponse<GetUsagesDetailsResponse, ErrorsResponse> GetCurrentUsages(ListUsageDetailsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/usages-details/";
            var query = request.ToDictionary();

            return this.SendRequest<GetUsagesDetailsResponse>(method, endpoint, null, query);
        }

        public BaseResponse<ListUsagesResponse, ErrorsResponse> ListUsages(ListUsagesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/items/{request.ItemId}/usages";
            var query = request.ToDictionary();

            return this.SendRequest<ListUsagesResponse>(method, endpoint, null, query);
        }

        public BaseResponse<GetUsageResponse, ErrorsResponse> DeleteUsage(string subscriptionId, string itemId, string usageId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}/usages/{usageId}";

            return this.SendRequest<GetUsageResponse>(method, endpoint, null);
        }

        #endregion
    }
}