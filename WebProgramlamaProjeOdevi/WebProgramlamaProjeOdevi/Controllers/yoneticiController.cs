using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaProjeOdevi.Models;

namespace WebProgramlamaProjeOdevi.Controllers
{
    public class yoneticiController:Controller
    {
        HaberDBAccessLayer hbdb = new HaberDBAccessLayer();

        [HttpGet]
        public IActionResult yonetimPanel()
        {
            return View();
        }
        [HttpPost]
        public IActionResult yonetimPanel([Bind] HaberModel habermodel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string resp = hbdb.AddHaberRecord(habermodel);
                    TempData["msg"] = resp;
                }
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            return View();
        }

    }
}
