using Mundipagg.Models;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using System.Net.Http;

namespace Mundipagg.Resources
{
    /// <summary>
    /// Customer manager
    /// </summary>
    public class CustomerResource : BaseResource, ICustomerResource
    {
        /// <summary>
        /// Creates a new customer manager
        /// </summary>
        /// <param name="configuration">Mundipagg Api configuration</param>
        public CustomerResource(Configuration configuration) : base(configuration) {}

        /// <summary>
        /// Create new customer
        /// </summary>
        /// <param name="request">Create customer request</param>
        /// <returns>Base response with customer data</returns>
        public BaseResponse<GetCustomerResponse> CreateCustomer(CreateCustomerRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/core/v1/customers";
            
            return this.HttpClientUtil.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }

        /// <summary>
        /// Update a customer
        /// </summary>
        /// <param name="customerId">Customer code</param>
        /// <param name="request">Update customer request</param>
        /// <returns>Base response with customer data</returns>
        public BaseResponse<GetCustomerResponse> UpdateCustomer(string customerId, UpdateCustomerRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/core/v1/customers/{customerId}";

            return this.HttpClientUtil.SendRequest<GetCustomerResponse>(method, endpoint, request);
        }

        /// <summary>
        /// Get customer data
        /// </summary>
        /// <param name="customerId">Customer code</param>
        /// <returns>Base response with customer data</returns>
        public BaseResponse<GetCustomerResponse> GetCustomer(string customerId)
        {            
            var method = HttpMethod.Get;
            var endpoint = $"/core/v1/customers/{customerId}";

            return this.HttpClientUtil.SendRequest<GetCustomerResponse>(method, endpoint, null);
        }

        /// <summary>
        /// List customers
        /// </summary>
        /// <param name="request">List customers request</param>
        /// <returns>Base response with paged customers data</returns>
        public BaseResponse<PagingResponse<GetCustomerResponse>> ListCustomers(ListCustomersRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/core/v1/customers";
            var query = request.ToDictionary();

            return this.HttpClientUtil.SendRequest<PagingResponse<GetCustomerResponse>>(method, endpoint, null, query);
        }
    }
}
