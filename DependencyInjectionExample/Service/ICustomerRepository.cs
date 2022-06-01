using DependencyInjectionExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Service
{
    public interface ICustomerRepository
    {
        List<Request> GetRequest();
    }
}
