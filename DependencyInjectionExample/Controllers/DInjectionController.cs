using DependencyInjectionExample.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Controllers
{
    public class DInjectionController : Controller
    {

        //injeção de dependencia
        private readonly ICustomerService _customerService;

        public DInjectionController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        public IActionResult Index()
        {
            var request = _customerService.GetRequestCustomer();
            return View(request);
        }
    }
}
