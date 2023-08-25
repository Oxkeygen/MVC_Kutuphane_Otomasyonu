using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasyonu.Entities.Model
{
    public class KitapHareketleri
    {
        public string Id { get; set; }
        public string KullaniciId { get; set; }
        public string UyeId { get; set; }
        public int KitapId { get; set; }
        public string YapilanIslem { get; set; }
        public DateTime Tarih { get; set; }

        public Kitaplar Kitaplar { get; set; }

    }
}
