using FluentValidation;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasyonu.Entities.Validations
{
    public class KitapTurleriValidators:AbstractValidator<KitapTurleri>
    {
        public KitapTurleriValidators()
        {
            RuleFor(x => x.KitapTuru).NotEmpty().WithMessage("Kitap Türü Alanı Boş Geçilemez");
            RuleFor(x => x.KitapTuru).MaximumLength(150).WithMessage("Kitap Türü Alanı En Fazla 150 Karakter Olabilir.");

        }
    }
}
