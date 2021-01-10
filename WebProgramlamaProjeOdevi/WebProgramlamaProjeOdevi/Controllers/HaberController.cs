using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaProjeOdevi.Models;

namespace WebProgramlamaProjeOdevi.Controllers
{
    public class HaberController : Controller
    {
  
        
        public IActionResult Haberindex()
        {
            String connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-WebProgramlamaProjeOdevi-8ED536E3-45A2-46E8-87FD-1408BA3E2B4F;Trusted_Connection=True;MultipleActiveResultSets=true";
            String sql = "SELECT * FROM Haber";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);

            var model = new List<HaberModel>();

            
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var haber = new HaberModel();
                    haber.haber_baslik = (string)rdr["haber_baslik"];
                    haber.haber_icerik = (string)rdr["haber_icerik"];
                    haber.haber_tarih = (DateTime)rdr["haber_tarih"];
                    haber.haber_gorsel = (string)rdr["haber_gorsel"];
                model.Add(haber);
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

