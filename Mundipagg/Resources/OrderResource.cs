using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace Mundipagg.Resources
{
    public class OrderResource : BaseResource, IOrderResource
    {
        public OrderResource(Configuration configuration) : base(configuration) { }

        #region Order

        public BaseResponse<GetOrderResponse, ErrorsResponse> GetOrder(string orderId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/orders/{orderId}";

            return this.SendRequest<GetOrderResponse>(method, endpoint, null);
        }

        public BaseResponse<GetOrderResponse, ErrorsResponse> CreateOrder(string idempotencyKey, CreateOrderRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/orders";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return this.SendRequest<GetOrderResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<ListOrderResponse, ErrorsResponse> ListOrders(ListOrdersRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/orders";
            var query = request.ToDictionary();

            return this.SendRequest<ListOrderResponse>(method, endpoint, null, query);
        }

        public BaseResponse<GetOrderResponse, ErrorsResponse> UpdateOrderMetadata(string orderId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/orders/{orderId}/metadata";
            var query = request.ToDictionary();

            return this.SendRequest<GetOrderResponse>(method, endpoint, request);
        }

        public BaseResponse<GetOrderResponse, ErrorsResponse> CloseOrder(string id, UpdateOrderStatusRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/orders/{id}/closed";
            var query = request.ToDictionary();

            return this.SendRequest<GetOrderResponse>(method, endpoint, request);
        }

        #endregion

        #region Order Item 

        public BaseResponse<GetOrderItemResponse, ErrorsResponse> GetOrderItem(string orderId, string itemId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/orders/{orderId}/{itemId}";

            return this.SendRequest<GetOrderItemResponse>(method, endpoint, null);
        }

        public BaseResponse<GetOrderItemResponse, ErrorsResponse> CreateOrderItem(string orderId, CreateOrderItemRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/orders/{orderId}/items";

            return this.SendRequest<GetOrderItemResponse>(method, endpoint, request);
        }

        public BaseResponse<GetOrderResponse, ErrorsResponse> DeleteAllOrderItems(string orderId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/orders/{orderId}/items";

            return this.SendRequest<GetOrderResponse>(method, endpoint, null);
        }

        public BaseResponse<GetOrderItemResponse, ErrorsResponse> DeleteOrderItem(string orderId, string itemId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/orders/{orderId}/items/{itemId}";

            return this.SendRequest<GetOrderItemResponse>(method, endpoint, null);
        }

        public BaseResponse<GetOrderItemResponse, ErrorsResponse> UpdateOrderItem(string orderId, string itemId, UpdateOrderItemRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/orders/{orderId}/items/{itemId}";

            return this.SendRequest<GetOrderItemResponse>(method, endpoint, request);
        }

        #endregion        
    }
}