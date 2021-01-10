using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaProjeOdevi.Models
{
    public class HaberModel
    {
        [Required]
        public string haber_baslik { get; set; }
        [Required]
        public string haber_icerik { get; set; }

        public DateTime haber_tarih { get; set; }

        public string haber_gorsel { get; set; }
    }
}
