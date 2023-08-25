using FluentValidation;
using MVC_Kutuphane_Otomasyonu.Entities.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasyonu.Entities.Validations
{
    public class KitaplarValidators:AbstractValidator<Kitaplar>
    {
        public KitaplarValidators()
        {
            RuleFor(x => x.BarkodNo).NotEmpty().WithMessage("BarkodNo Alanı Boş Geçilemez");
            RuleFor(x => x.BarkodNo).MaximumLength(30).WithMessage("BarkodNo Alanı En Fazla 30 Karakter Olabilir.");

            RuleFor(x => x.KitapAdi).NotEmpty().WithMessage("BarkodNo Alanı Boş Geçilemez");
            RuleFor(x => x.KitapAdi).MaximumLength(100).WithMessage("Kitap Adı Alanı En Fazla 100 Karakter Olabilir.");
            RuleFor(x => x.Yazari).NotEmpty().WithMessage("Yazar Alanı Boş Geçilemez");
            RuleFor(x => x.Yazari).MaximumLength(100).WithMessage("Yazar Adı Alanı En Fazla 100 Karakter Olabilir.");
            RuleFor(x => x.YayinEvi).NotEmpty().WithMessage("YayınEvi Alanı Boş Geçilemez");
            RuleFor(x => x.YayinEvi).MaximumLength(150).WithMessage("Yayınevi Alanı En Fazla 150 Karakter Olabilir.");
        }
    }
}
