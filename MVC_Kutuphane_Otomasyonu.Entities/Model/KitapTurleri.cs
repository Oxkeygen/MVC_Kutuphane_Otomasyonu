using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasyonu.Entities.Model
{
   public class KitapTurleri
    {       
        public int Id { get; set; }
        public string KitapTuru { get; set; }
        public string Aciklama { get; set; }

        public List<Kitaplar> Kitaplar { get; set; }//Çoğul Adlandırma

    }
}
