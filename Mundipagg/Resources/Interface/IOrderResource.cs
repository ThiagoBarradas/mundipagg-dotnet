using Mundipagg.Models.Request;
using Mundipagg.Models.Response;

namespace Mundipagg.Resources.Interface
{
    public interface IOrderResource
    {
        /// <summary>
        /// Gets an order
        /// </summary>
        /// <param name="orderId">Required parameter: Order id</param>
        /// <return>Returns the Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse> GetOrder(string orderId);

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <return>Returns the Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse> CreateOrder(CreateOrderRequest body);

        /// <summary>
        /// Gets all orders
        /// </summary>
        /// <return>Returns the Models.BaseResponse<ListOrderResponse> response from the API call</return>
        BaseResponse<ListOrderResponse> GetOrders(ListOrdersRequest request);

        /// <summary>
        /// Updates the metadata from an order
        /// </summary>
        /// <param name="orderId">Required parameter: The order id</param>
        /// <param name="request">Required parameter: Request for updating the order metadata</param>
        /// <return>Returns the Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse> UpdateOrderMetadata(string orderId, UpdateMetadataRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <return>Returns the Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse> DeleteAllOrderItems(string orderId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <param name="request">Required parameter: Item Model</param>
        /// <return>Returns the Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse> UpdateOrderItem(string orderId, string itemId, UpdateOrderItemRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns the Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse> DeleteOrderItem(string orderId, string itemId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Order Item Model</param>
        /// <return>Returns the Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse> CreateOrderItem(string orderId, CreateOrderItemRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns the Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse> GetOrderItem(string orderId, string itemId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Update Order Model</param>
        /// <return>Returns the Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse> UpdateOrderStatus(string id, UpdateOrderStatusRequest request);
    }
}