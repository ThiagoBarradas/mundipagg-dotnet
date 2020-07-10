using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;

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
        BaseResponse<GetOrderResponse, MundipaggErrorsResponse> GetOrder(string orderId);

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse, MundipaggErrorsResponse> CreateOrder(string idempotencyKey, CreateOrderRequest body);

        /// <summary>
        /// Lists orders
        /// </summary>
        /// <return>Returns Models.BaseResponse<PagingResponse<GetOrderResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetOrderResponse>, MundipaggErrorsResponse> ListOrders(ListOrdersRequest request);

        /// <summary>
        /// Updates the metadata from an order
        /// </summary>
        /// <param name="orderId">Required parameter: The order id</param>
        /// <param name="request">Required parameter: Request for updating the order metadata</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse, MundipaggErrorsResponse> UpdateOrderMetadata(string orderId, UpdateMetadataRequest request);

        /// <summary>
        /// Closes an order
        /// </summary>
        /// <param name="id">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Update Order Model</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse, MundipaggErrorsResponse> CloseOrder(string id, UpdateOrderStatusRequest request);

        #endregion

        #region Order Item

        /// <summary>
        /// Create Order Item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Order Item Model</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse> CreateOrderItem(string orderId, CreateOrderItemRequest request);

        /// <summary>
        /// Get order item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse> GetOrderItem(string orderId, string itemId);

        /// <summary>
        /// Delete all order items
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse, MundipaggErrorsResponse> DeleteAllOrderItems(string orderId);

        /// <summary>
        /// Delete order item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse> DeleteOrderItem(string orderId, string itemId);

        /// <summary>
        /// Update Order Item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <param name="request">Required parameter: Item Model</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse> UpdateOrderItem(string orderId, string itemId, UpdateOrderItemRequest request);

        #endregion
    }
}