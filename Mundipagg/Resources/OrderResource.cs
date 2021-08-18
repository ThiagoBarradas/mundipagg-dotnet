using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using RestSharp.Easy.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mundipagg.Resources
{
    public class OrderResource : BaseResource, IOrderResource
    {
        public OrderResource(Configuration configuration) : base(configuration) { }

        #region Order

        public BaseResponse<GetOrderResponse, MundipaggErrorsResponse> GetOrder(string orderId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/orders/{orderId}";

            return this.SendRequest<GetOrderResponse>(method, endpoint, null);
        }

        public async Task<BaseResponse<GetOrderResponse, MundipaggErrorsResponse>> GetOrderAsync(string orderId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/orders/{orderId}";

            return await this.SendRequestAsync<GetOrderResponse>(method, endpoint, null);
        }

        public BaseResponse<GetOrderResponse, MundipaggErrorsResponse> CreateOrder(string idempotencyKey, CreateOrderRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/orders";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return this.SendRequest<GetOrderResponse>(method, endpoint, request, null, headers);
        }

        public async Task<BaseResponse<GetOrderResponse, MundipaggErrorsResponse>> CreateOrderAsync(string idempotencyKey, CreateOrderRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/orders";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return await this.SendRequestAsync<GetOrderResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<GetOrderResponse, MundipaggErrorsResponse> CreateOrder(CreateOrderRequest request, Dictionary<string, string> headers)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/orders";

            return this.SendRequest<GetOrderResponse>(method, endpoint, request, null, headers);
        }

        public async Task<BaseResponse<GetOrderResponse, MundipaggErrorsResponse>> CreateOrderAsync(CreateOrderRequest request, Dictionary<string, string> headers)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/orders";

            return await this.SendRequestAsync<GetOrderResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<PagingResponse<GetOrderResponse>, MundipaggErrorsResponse> ListOrders(ListOrdersRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/orders";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetOrderResponse>>(method, endpoint, null, query);
        }

        public async Task<BaseResponse<PagingResponse<GetOrderResponse>, MundipaggErrorsResponse>> ListOrdersAsync(ListOrdersRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/orders";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<PagingResponse<GetOrderResponse>>(method, endpoint, null, query);
        }

        public BaseResponse<GetOrderResponse, MundipaggErrorsResponse> UpdateOrderMetadata(string orderId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/orders/{orderId}/metadata";
            var query = request.ToDictionary();

            return this.SendRequest<GetOrderResponse>(method, endpoint, request);
        }

        public async Task<BaseResponse<GetOrderResponse, MundipaggErrorsResponse>> UpdateOrderMetadataAsync(string orderId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/orders/{orderId}/metadata";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<GetOrderResponse>(method, endpoint, request);
        }

        public BaseResponse<GetOrderResponse, MundipaggErrorsResponse> CloseOrder(string id, UpdateOrderStatusRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/orders/{id}/closed";
            var query = request.ToDictionary();

            return this.SendRequest<GetOrderResponse>(method, endpoint, request);
        }

        public async Task<BaseResponse<GetOrderResponse, MundipaggErrorsResponse>> CloseOrderAsync(string id, UpdateOrderStatusRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/orders/{id}/closed";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<GetOrderResponse>(method, endpoint, request);
        }

        #endregion

        #region Order Item 

        public BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse> GetOrderItem(string orderId, string itemId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/orders/{orderId}/{itemId}";

            return this.SendRequest<GetOrderItemResponse>(method, endpoint, null);
        }

        public async Task<BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse>> GetOrderItemAsync(string orderId, string itemId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/orders/{orderId}/{itemId}";

            return await this.SendRequestAsync<GetOrderItemResponse>(method, endpoint, null);
        }

        public BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse> CreateOrderItem(string orderId, CreateOrderItemRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/orders/{orderId}/items";

            return this.SendRequest<GetOrderItemResponse>(method, endpoint, request);
        }

        public async Task<BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse>> CreateOrderItemAsync(string orderId, CreateOrderItemRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/orders/{orderId}/items";

            return await this.SendRequestAsync<GetOrderItemResponse>(method, endpoint, request);
        }

        public BaseResponse<GetOrderResponse, MundipaggErrorsResponse> DeleteAllOrderItems(string orderId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/orders/{orderId}/items";

            return this.SendRequest<GetOrderResponse>(method, endpoint, null);
        }

        public async Task<BaseResponse<GetOrderResponse, MundipaggErrorsResponse>> DeleteAllOrderItemsAsync(string orderId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/orders/{orderId}/items";

            return await this.SendRequestAsync<GetOrderResponse>(method, endpoint, null);
        }

        public BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse> DeleteOrderItem(string orderId, string itemId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/orders/{orderId}/items/{itemId}";

            return this.SendRequest<GetOrderItemResponse>(method, endpoint, null);
        }

        public async Task<BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse>> DeleteOrderItemAsync(string orderId, string itemId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/orders/{orderId}/items/{itemId}";

            return await this.SendRequestAsync<GetOrderItemResponse>(method, endpoint, null);
        }

        public BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse> UpdateOrderItem(string orderId, string itemId, UpdateOrderItemRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/orders/{orderId}/items/{itemId}";

            return this.SendRequest<GetOrderItemResponse>(method, endpoint, request);
        }

        public async Task<BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse>> UpdateOrderItemAsync(string orderId, string itemId, UpdateOrderItemRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/orders/{orderId}/items/{itemId}";

            return await this.SendRequestAsync<GetOrderItemResponse>(method, endpoint, request);
        }

        #endregion        
    }
}