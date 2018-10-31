using MundiPagg.Models.Request;
using MundiPagg.Models.Response;

namespace MundiPagg.Resources.Interface
{
    /// <summary>
    /// Customer manager
    /// </summary>
    public interface ICustomerResource
    {
        /// <summary>
        /// Create new customer
        /// </summary>
        /// <param name="request">Create customer request</param>
        /// <returns>Base response with customer data</returns>
        BaseResponse<GetCustomerResponse> CreateCustomer(CreateCustomerRequest request);

        /// <summary>
        /// Update a customer
        /// </summary>
        /// <param name="customerId">Customer code</param>
        /// <param name="request">Update customer request</param>
        /// <returns>Base response with customer data</returns>
        BaseResponse<GetCustomerResponse> UpdateCustomer(string customerId, UpdateCustomerRequest request);

        /// <summary>
        /// Get customer data
        /// </summary>
        /// <param name="customerId">Customer code</param>
        /// <returns>Base response with customer data</returns>
        BaseResponse<GetCustomerResponse> GetCustomer(string customerId);

        /// <summary>
        /// List customers
        /// </summary>
        /// <param name="request">List customer request</param>
        /// <returns>Base response with paged customers data</returns>
        BaseResponse<PagingResponse<GetCustomerResponse>> ListCustomers(ListCustomersRequest request);
    }
}
