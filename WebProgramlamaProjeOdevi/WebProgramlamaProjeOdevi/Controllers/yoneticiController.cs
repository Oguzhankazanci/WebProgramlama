using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaProjeOdevi.Controllers
{
    public class yoneticiController:Controller
    {
        public IActionResult yonetimPanel()
        {
            return View();
        }

    }
}
