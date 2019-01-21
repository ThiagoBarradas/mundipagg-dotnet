using Mundipagg.Models.Request;
using Mundipagg.Models.Response;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Order manager
    /// </summary>
    public interface IOrderResource : IResource
    {
        #region Order

        /// <summary>
        /// Gets an order
        /// </summary>
        /// <param name="orderId">Required parameter: Order id</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse> GetOrder(string orderId);

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse> CreateOrder(CreateOrderRequest body);

        /// <summary>
        /// Lists orders
        /// </summary>
        /// <return>Returns Models.BaseResponse<ListOrderResponse> response from the API call</return>
        BaseResponse<ListOrderResponse> ListOrders(ListOrdersRequest request);

        /// <summary>
        /// Updates the metadata from an order
        /// </summary>
        /// <param name="orderId">Required parameter: The order id</param>
        /// <param name="request">Required parameter: Request for updating the order metadata</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse> UpdateOrderMetadata(string orderId, UpdateMetadataRequest request);

        /// <summary>
        /// Closes an order
        /// </summary>
        /// <param name="id">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Update Order Model</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse> CloseOrder(string id, UpdateOrderStatusRequest request);

        #endregion

        #region Order Item

        /// <summary>
        /// Create Order Item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Order Item Model</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse> CreateOrderItem(string orderId, CreateOrderItemRequest request);

        /// <summary>
        /// Get order item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse> GetOrderItem(string orderId, string itemId);

        /// <summary>
        /// Delete all order items
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse> DeleteAllOrderItems(string orderId);

        /// <summary>
        /// Delete order item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse> DeleteOrderItem(string orderId, string itemId);

        /// <summary>
        /// Update Order Item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <param name="request">Required parameter: Item Model</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse> UpdateOrderItem(string orderId, string itemId, UpdateOrderItemRequest request);

        #endregion
    }
}