using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaProjeOdevi.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IStringLocalizer<CustomerController> _localizer;
        public CustomerController(IStringLocalizer<CustomerController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            var message = _localizer["Message"];
            ViewData["Message"] = message;
            return View();
        }
    }
}
