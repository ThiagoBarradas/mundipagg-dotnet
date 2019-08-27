using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using System.Net.Http;

namespace Mundipagg.Resources
{
    public class OrderResource : BaseResource, IOrderResource
    {
        public OrderResource(Configuration configuration) : base(configuration) { }

        #region Order

        public BaseResponse<GetOrderResponse> GetOrder(string orderId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/orders/{orderId}";

            return this.HttpClientUtil.SendRequest<GetOrderResponse>(method, endpoint, null);
        }

        public BaseResponse<GetOrderResponse> CreateOrder(string idempotencyKey, CreateOrderRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/orders";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return this.HttpClientUtil.SendRequest<GetOrderResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<ListOrderResponse> ListOrders(ListOrdersRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/orders";
            var query = request.ToDictionary();

            return this.HttpClientUtil.SendRequest<ListOrderResponse>(method, endpoint, null, query);
        }

        public BaseResponse<GetOrderResponse> UpdateOrderMetadata(string orderId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/orders/{orderId}/metadata";
            var query = request.ToDictionary();

            return this.HttpClientUtil.SendRequest<GetOrderResponse>(method, endpoint, request);
        }

        public BaseResponse<GetOrderResponse> CloseOrder(string id, UpdateOrderStatusRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/orders/{id}/closed";
            var query = request.ToDictionary();

            return this.HttpClientUtil.SendRequest<GetOrderResponse>(method, endpoint, request);
        }

        #endregion

        #region Order Item 

        public BaseResponse<GetOrderItemResponse> GetOrderItem(string orderId, string itemId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/orders/{orderId}/{itemId}";

            return this.HttpClientUtil.SendRequest<GetOrderItemResponse>(method, endpoint, null);
        }

        public BaseResponse<GetOrderItemResponse> CreateOrderItem(string orderId, CreateOrderItemRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/orders/{orderId}/items";

            return this.HttpClientUtil.SendRequest<GetOrderItemResponse>(method, endpoint, request);
        }

        public BaseResponse<GetOrderResponse> DeleteAllOrderItems(string orderId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/orders/{orderId}/items";

            return this.HttpClientUtil.SendRequest<GetOrderResponse>(method, endpoint, null);
        }

        public BaseResponse<GetOrderItemResponse> DeleteOrderItem(string orderId, string itemId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/orders/{orderId}/items/{itemId}";

            return this.HttpClientUtil.SendRequest<GetOrderItemResponse>(method, endpoint, null);
        }

        public BaseResponse<GetOrderItemResponse> UpdateOrderItem(string orderId, string itemId, UpdateOrderItemRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/orders/{orderId}/items/{itemId}";

            return this.HttpClientUtil.SendRequest<GetOrderItemResponse>(method, endpoint, request);
        }

        #endregion        
    }
}