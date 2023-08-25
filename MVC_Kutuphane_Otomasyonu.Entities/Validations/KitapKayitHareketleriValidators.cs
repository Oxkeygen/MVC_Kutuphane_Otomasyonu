using FluentValidation;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasyonu.Entities.Validations
{
    public class KitapKayitHareketleriValidators:AbstractValidator<KitapKayitHareketleri>
    {
        public KitapKayitHareketleriValidators()
        {
            RuleFor(x => x.YapilanIslem).MaximumLength(150).WithMessage("Yapılan İşlem Alanı En Fazla 150 Karakter Olabilir.");

        }
    }
}
