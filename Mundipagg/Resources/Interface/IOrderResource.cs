using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        /// Gets an order
        /// </summary>
        /// <param name="orderId">Required parameter: Order id</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        Task<BaseResponse<GetOrderResponse, MundipaggErrorsResponse>> GetOrderAsync(string orderId);

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse, MundipaggErrorsResponse> CreateOrder(string idempotencyKey, CreateOrderRequest body);

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        Task<BaseResponse<GetOrderResponse, MundipaggErrorsResponse>> CreateOrderAsync(string idempotencyKey, CreateOrderRequest body);

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse, MundipaggErrorsResponse> CreateOrder(CreateOrderRequest body, Dictionary<string, string> headers);

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        Task<BaseResponse<GetOrderResponse, MundipaggErrorsResponse>> CreateOrderAsync(CreateOrderRequest body, Dictionary<string, string> headers);

        /// <summary>
        /// Lists orders
        /// </summary>
        /// <return>Returns Models.BaseResponse<PagingResponse<GetOrderResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetOrderResponse>, MundipaggErrorsResponse> ListOrders(ListOrdersRequest request);

        /// <summary>
        /// Lists orders
        /// </summary>
        /// <return>Returns Models.BaseResponse<PagingResponse<GetOrderResponse>> response from the API call</return>
        Task<BaseResponse<PagingResponse<GetOrderResponse>, MundipaggErrorsResponse>> ListOrdersAsync(ListOrdersRequest request);

        /// <summary>
        /// Updates the metadata from an order
        /// </summary>
        /// <param name="orderId">Required parameter: The order id</param>
        /// <param name="request">Required parameter: Request for updating the order metadata</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse, MundipaggErrorsResponse> UpdateOrderMetadata(string orderId, UpdateMetadataRequest request);

        /// <summary>
        /// Updates the metadata from an order
        /// </summary>
        /// <param name="orderId">Required parameter: The order id</param>
        /// <param name="request">Required parameter: Request for updating the order metadata</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        Task<BaseResponse<GetOrderResponse, MundipaggErrorsResponse>> UpdateOrderMetadataAsync(string orderId, UpdateMetadataRequest request);

        /// <summary>
        /// Closes an order
        /// </summary>
        /// <param name="id">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Update Order Model</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse, MundipaggErrorsResponse> CloseOrder(string id, UpdateOrderStatusRequest request);

        /// <summary>
        /// Closes an order
        /// </summary>
        /// <param name="id">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Update Order Model</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        Task<BaseResponse<GetOrderResponse, MundipaggErrorsResponse>> CloseOrderAsync(string id, UpdateOrderStatusRequest request);

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
        /// Create Order Item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="request">Required parameter: Order Item Model</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        Task<BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse>> CreateOrderItemAsync(string orderId, CreateOrderItemRequest request);

        /// <summary>
        /// Get order item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse> GetOrderItem(string orderId, string itemId);

        /// <summary>
        /// Get order item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        Task<BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse>> GetOrderItemAsync(string orderId, string itemId);

        /// <summary>
        /// Delete all order items
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        BaseResponse<GetOrderResponse, MundipaggErrorsResponse> DeleteAllOrderItems(string orderId);

        /// <summary>
        /// Delete all order items
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <return>Returns Models.BaseResponse<GetOrderResponse> response from the API call</return>
        Task<BaseResponse<GetOrderResponse, MundipaggErrorsResponse>> DeleteAllOrderItemsAsync(string orderId);

        /// <summary>
        /// Delete order item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse> DeleteOrderItem(string orderId, string itemId);

        /// <summary>
        /// Delete order item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        Task<BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse>> DeleteOrderItemAsync(string orderId, string itemId);

        /// <summary>
        /// Update Order Item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <param name="request">Required parameter: Item Model</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse> UpdateOrderItem(string orderId, string itemId, UpdateOrderItemRequest request);

        /// <summary>
        /// Update Order Item
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <param name="request">Required parameter: Item Model</param>
        /// <return>Returns Models.BaseResponse<GetOrderItemResponse> response from the API call</return>
        Task<BaseResponse<GetOrderItemResponse, MundipaggErrorsResponse>> UpdateOrderItemAsync(string orderId, string itemId, UpdateOrderItemRequest request);

        #endregion
    }
}