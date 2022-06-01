using DependencyInjectionExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Service
{
    public class CustomerRepository : ICustomerRepository
    {

        public List<Request> GetRequest()
        {
            var request = new List<Request>();

            request.Add(new Request
            {
                RequestId = 1,
                CustomerId = 1000
            });

            request.Add(new Request
            {
                RequestId = 2,
                CustomerId = 1001
            });

            return request;




        }
    }
}
