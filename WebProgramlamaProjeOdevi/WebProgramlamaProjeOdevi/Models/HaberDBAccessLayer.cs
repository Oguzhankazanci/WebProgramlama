using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaProjeOdevi.Models
{
    public class HaberDBAccessLayer
    {
        SqlConnection con = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=aspnet-WebProgramlamaProjeOdevi-8ED536E3-45A2-46E8-87FD-1408BA3E2B4F;Trusted_Connection=True;MultipleActiveResultSets=true");
        public string AddHaberRecord(HaberModel habermodel)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Haberr", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@haber_baslik", habermodel.haber_baslik);
                cmd.Parameters.AddWithValue("@haber_icerik", habermodel.haber_icerik);
                cmd.Parameters.AddWithValue("@haber_tarih", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@haber_gorsel", habermodel.haber_gorsel);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Data save Successfully");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }
    }
}
