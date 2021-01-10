using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaProjeOdevi.Models;

namespace WebProgramlamaProjeOdevi.Controllers
{
    public class HaberlerController : Controller
    {
  
        
        public IActionResult Haberlerindex()
        {
            String connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-WebProgramlamaProjeOdevi-8ED536E3-45A2-46E8-87FD-1408BA3E2B4F;Trusted_Connection=True;MultipleActiveResultSets=true";
            String sql = "SELECT * FROM Haberler";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);

            var model = new List<HaberlerModel>();

            
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var haberler = new HaberlerModel();
                    haberler.haberler_baslik = (string)rdr["haberler_baslik"];
                    haberler.haberler_icerik = (string)rdr["haberler_icerik"];
                    haberler.haberler_tarih = (DateTime)rdr["haberler_tarih"];
                    haberler.haberler_gorsel = (string)rdr["haberler_gorsel"];
                model.Add(haberler);
                }

            

            return View(model);
        }
       // HaberDBAccessLayer hbdb = new HaberDBAccessLayer();
       // [HttpGet]
       // public IActionResult Index1()
       // {
       //     return View();
       // }
       // [HttpPost]
       // public IActionResult Index1([Bind] HaberModel habermodel)
       // {
       //     try
       //     {
       //         if (ModelState.IsValid)
       //         {
       //             string resp = hbdb.AddHaberRecord(habermodel);
       //             TempData["msg"] = resp;
       //         }
       //     }
       //     catch (Exception ex)
       //     {
       //         TempData["msg"] = ex.Message;
       //     }
       //     return View();
       // }
    }
}

