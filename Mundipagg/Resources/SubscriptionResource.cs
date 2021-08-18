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
    public class SubscriptionResource : BaseResource, ISubscriptionResource
    {
        public SubscriptionResource(Configuration configuration) : base(configuration) { }

        #region Subscription

        public BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> GetSubscription(string subscriptionId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> GetSubscriptionAsync(string subscriptionId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}";

            return await this.SendRequestAsync<GetSubscriptionResponse>(method, endpoint, null);
        }


        public BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> CreateSubscription(CreateSubscriptionRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> CreateSubscriptionAsync(CreateSubscriptionRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions";

            return await this.SendRequestAsync<GetSubscriptionResponse>(method, endpoint, request);
        }


        public BaseResponse<PagingResponse<GetSubscriptionResponse>, MundipaggErrorsResponse> ListSubscriptions(ListSubscriptionsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetSubscriptionResponse>>(method, endpoint, null, query);
        }


        public async Task<BaseResponse<PagingResponse<GetSubscriptionResponse>, MundipaggErrorsResponse>> ListSubscriptionsAsync(ListSubscriptionsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<PagingResponse<GetSubscriptionResponse>>(method, endpoint, null, query);
        }


        public BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> CancelSubscription(string subscriptionId, CreateCancelSubscriptionRequest request = null)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> CancelSubscriptionAsync(string subscriptionId, CreateCancelSubscriptionRequest request = null)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}";

            return await this.SendRequestAsync<GetSubscriptionResponse>(method, endpoint, request);
        }


        public BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionMetadata(string subscriptionId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/metadata";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionMetadataAsync(string subscriptionId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/metadata";

            return await this.SendRequestAsync<GetSubscriptionResponse>(method, endpoint, request);
        }


        public BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionMiniumPrice(string subscriptionId, UpdateSubscriptionMinimumPriceRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/minimum_price";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionMiniumPriceAsync(string subscriptionId, UpdateSubscriptionMinimumPriceRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/minimum_price";

            return await this.SendRequestAsync<GetSubscriptionResponse>(method, endpoint, request);
        }


        public BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionPaymentMethod(string subscriptionId, UpdateSubscriptionPaymentMethodRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/payment-method";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionPaymentMethodAsync(string subscriptionId, UpdateSubscriptionPaymentMethodRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/payment-method";

            return await this.SendRequestAsync<GetSubscriptionResponse>(method, endpoint, request);
        }


        public BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionStartAt(string subscriptionId, UpdateSubscriptionStartAtRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/start-at";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }

        public async Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionStartAtAsync(string subscriptionId, UpdateSubscriptionStartAtRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/start-at";

            return await this.SendRequestAsync<GetSubscriptionResponse>(method, endpoint, request);
        }

        #endregion

        #region Subscription Item
        public BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse> GetSubscriptionItem(string subscriptionId, string itemId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse>> GetSubscriptionItemAsync(string subscriptionId, string itemId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}";

            return await this.SendRequestAsync<GetSubscriptionItemResponse>(method, endpoint, null);
        }


        public BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse> CreateSubscriptionItem(string subscriptionId, CreateSubscriptionItemRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/items";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse>> CreateSubscriptionItemAsync(string subscriptionId, CreateSubscriptionItemRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/items";

            return await this.SendRequestAsync<GetSubscriptionItemResponse>(method, endpoint, request);
        }


        public BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse> DeleteSubscriptionItem(string subscriptionId, string subscriptionItemId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{subscriptionItemId}";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse>> DeleteSubscriptionItemAsync(string subscriptionId, string subscriptionItemId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{subscriptionItemId}";

            return await this.SendRequestAsync<GetSubscriptionItemResponse>(method, endpoint, null);
        }


        public BaseResponse<PagingResponse<GetSubscriptionItemResponse>, MundipaggErrorsResponse> ListSubscriptionItems(ListSubscriptionItemsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/items";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetSubscriptionItemResponse>>(method, endpoint, null, query);
        }


        public async Task<BaseResponse<PagingResponse<GetSubscriptionItemResponse>, MundipaggErrorsResponse>> ListSubscriptionItemsAsync(ListSubscriptionItemsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/items";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<PagingResponse<GetSubscriptionItemResponse>>(method, endpoint, null, query);
        }


        public BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse> UpdateSubscriptionItem(string subscriptionId, string itemId, UpdateSubscriptionItemRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse>> UpdateSubscriptionItemAsync(string subscriptionId, string itemId, UpdateSubscriptionItemRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}";

            return await this.SendRequestAsync<GetSubscriptionItemResponse>(method, endpoint, request);
        }


        public BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse> UpdateCurrentCycleEndDate(string subscriptionId, UpdateCurrentCycleEndDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/cycle-end-date";

            return this.SendRequest<GetSubscriptionItemResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetSubscriptionItemResponse, MundipaggErrorsResponse>> UpdateCurrentCycleEndDateAsync(string subscriptionId, UpdateCurrentCycleEndDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/cycle-end-date";

            return await this.SendRequestAsync<GetSubscriptionItemResponse>(method, endpoint, request);
        }


        public BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionAffiliationId(string subscriptionId, UpdateSubscriptionAffiliationIdRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/gateway-affiliation-id";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionAffiliationIdAsync(string subscriptionId, UpdateSubscriptionAffiliationIdRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/gateway-affiliation-id";

            return await this.SendRequestAsync<GetSubscriptionResponse>(method, endpoint, request);
        }


        public BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionBillingDate(string subscriptionId, UpdateSubscriptionBillingDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/billing-date";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionBillingDateAsync(string subscriptionId, UpdateSubscriptionBillingDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/billing-date";

            return await this.SendRequestAsync<GetSubscriptionResponse>(method, endpoint, request);
        }


        public BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionCard(string subscriptionId, UpdateSubscriptionCardRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/card";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionCardAsync(string subscriptionId, UpdateSubscriptionCardRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/card";

            return await this.SendRequestAsync<GetSubscriptionResponse>(method, endpoint, request);
        }


        public BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse> UpdateSubscriptionDueDays(string subscriptionId, UpdateSubscriptionDueDaysRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/boleto-due-days";

            return this.SendRequest<GetSubscriptionResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetSubscriptionResponse, MundipaggErrorsResponse>> UpdateSubscriptionDueDaysAsync(string subscriptionId, UpdateSubscriptionDueDaysRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/subscriptions/{subscriptionId}/boleto-due-days";

            return await this.SendRequestAsync<GetSubscriptionResponse>(method, endpoint, request);
        }

        #endregion

        #region Discount

        public BaseResponse<GetDiscountResponse, MundipaggErrorsResponse> CreateDiscount(string subscriptionId, CreateDiscountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts";

            return this.SendRequest<GetDiscountResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetDiscountResponse, MundipaggErrorsResponse>> CreateDiscountAsync(string subscriptionId, CreateDiscountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts";

            return await this.SendRequestAsync<GetDiscountResponse>(method, endpoint, request);
        }


        public BaseResponse<GetDiscountResponse, MundipaggErrorsResponse> GetDiscount(string subscriptionId, string discountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts/{discountId}";

            return this.SendRequest<GetDiscountResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetDiscountResponse, MundipaggErrorsResponse>> GetDiscountAsync(string subscriptionId, string discountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts/{discountId}";

            return await this.SendRequestAsync<GetDiscountResponse>(method, endpoint, null);
        }


        public BaseResponse<GetDiscountResponse, MundipaggErrorsResponse> DeleteDiscount(string subscriptionId, string discountId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts/{discountId}";

            return this.SendRequest<GetDiscountResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetDiscountResponse, MundipaggErrorsResponse>> DeleteDiscountAsync(string subscriptionId, string discountId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/discounts/{discountId}";

            return await this.SendRequestAsync<GetDiscountResponse>(method, endpoint, null);
        }


        public BaseResponse<PagingResponse<GetDiscountResponse>, MundipaggErrorsResponse> ListDiscounts(ListDiscountsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/discounts/";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetDiscountResponse>>(method, endpoint, null, query);
        }

        public async Task<BaseResponse<PagingResponse<GetDiscountResponse>, MundipaggErrorsResponse>> ListDiscountsAsync(ListDiscountsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/discounts/";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<PagingResponse<GetDiscountResponse>>(method, endpoint, null, query);
        }

        #endregion

        #region Increment

        public BaseResponse<GetIncrementResponse, MundipaggErrorsResponse> GetIncrement(string subscriptionId, string incrementId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/increments/{incrementId}";

            return this.SendRequest<GetIncrementResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetIncrementResponse, MundipaggErrorsResponse>> GetIncrementAsync(string subscriptionId, string incrementId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{subscriptionId}/increments/{incrementId}";

            return await this.SendRequestAsync<GetIncrementResponse>(method, endpoint, null);
        }


        public BaseResponse<GetIncrementResponse, MundipaggErrorsResponse> CreateIncrement(string subscriptionId, CreateIncrementRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/increments";

            return this.SendRequest<GetIncrementResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetIncrementResponse, MundipaggErrorsResponse>> CreateIncrementAsync(string subscriptionId, CreateIncrementRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/increments";

            return await this.SendRequestAsync<GetIncrementResponse>(method, endpoint, request);
        }


        public BaseResponse<GetIncrementResponse, MundipaggErrorsResponse> DeleteIncrement(string subscriptionId, string incrementId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/increments/{incrementId}";

            return this.SendRequest<GetIncrementResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetIncrementResponse, MundipaggErrorsResponse>> DeleteIncrementAsync(string subscriptionId, string incrementId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/increments/{incrementId}";

            return await this.SendRequestAsync<GetIncrementResponse>(method, endpoint, null);
        }


        public BaseResponse<PagingResponse<GetIncrementResponse>, MundipaggErrorsResponse> ListIncrements(ListIncrementsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/increments/";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetIncrementResponse>>(method, endpoint, null, query);
        }


        public async Task<BaseResponse<PagingResponse<GetIncrementResponse>, MundipaggErrorsResponse>> ListIncrementsAsync(ListIncrementsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/increments/";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<PagingResponse<GetIncrementResponse>>(method, endpoint, null, query);
        }

        #endregion

        #region Usage

        public BaseResponse<GetUsageResponse, MundipaggErrorsResponse> CreateUsage(string subscriptionId, string itemId, CreateUsageRequest request = null)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}/usages";

            return this.SendRequest<GetUsageResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetUsageResponse, MundipaggErrorsResponse>> CreateUsageAsync(string subscriptionId, string itemId, CreateUsageRequest request = null)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}/usages";

            return await this.SendRequestAsync<GetUsageResponse>(method, endpoint, request);
        }


        public BaseResponse<GetUsagesDetailsResponse, MundipaggErrorsResponse> GetCurrentUsages(ListUsageDetailsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/usages-details/";
            var query = request.ToDictionary();

            return this.SendRequest<GetUsagesDetailsResponse>(method, endpoint, null, query);
        }


        public async Task<BaseResponse<GetUsagesDetailsResponse, MundipaggErrorsResponse>> GetCurrentUsagesAsync(ListUsageDetailsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/usages-details/";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<GetUsagesDetailsResponse>(method, endpoint, null, query);
        }


        public BaseResponse<PagingResponse<GetUsageResponse>, MundipaggErrorsResponse> ListUsages(ListUsagesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/items/{request.ItemId}/usages";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetUsageResponse>>(method, endpoint, null, query);
        }


        public async Task<BaseResponse<PagingResponse<GetUsageResponse>, MundipaggErrorsResponse>> ListUsagesAsync(ListUsagesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/subscriptions/{request.SubscriptionId}/items/{request.ItemId}/usages";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<PagingResponse<GetUsageResponse>>(method, endpoint, null, query);
        }


        public BaseResponse<GetUsageResponse, MundipaggErrorsResponse> DeleteUsage(string subscriptionId, string itemId, string usageId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}/usages/{usageId}";

            return this.SendRequest<GetUsageResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetUsageResponse, MundipaggErrorsResponse>> DeleteUsageAsync(string subscriptionId, string itemId, string usageId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/subscriptions/{subscriptionId}/items/{itemId}/usages/{usageId}";

            return await this.SendRequestAsync<GetUsageResponse>(method, endpoint, null);
        }

        #endregion
    }
}