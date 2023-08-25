using FluentValidation;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasyonu.Entities.Validations
{
    public class IletisimValidators:AbstractValidator<Iletisim>
    {
        public IletisimValidators()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Alanı Boş Geçilemez.");
            RuleFor(x => x.Email).MaximumLength(150).WithMessage("Email Alanı En Fazla 150 Karakter Olabilir.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Bir Mail Adresi Formatı Giriniz.");
            ////////////////
            
            RuleFor(x => x.AdiSoyadi).NotEmpty().WithMessage("Adı Soyadı Alanı Boş Geçilemez.");
            RuleFor(x => x.AdiSoyadi).MaximumLength(100).WithMessage("Adı Soyadı Alanı En Fazla 100 Karakter Olabilir.");
            RuleFor(x => x.Baslik).NotEmpty().WithMessage("Başlık Alanı Boş Geçilemez.");
            RuleFor(x => x.Baslik).MaximumLength(200).WithMessage("Başlık Alanı En Fazla 200 Karakter Olabilir.");

            RuleFor(x => x.Mesaj).NotEmpty().WithMessage("Mesaj Alanı Boş Geçilemez.");
            RuleFor(x => x.Mesaj).MaximumLength(500).WithMessage("Mesaj Alanı En Fazla 500 Karakter Olabilir.");


        }
    }
}
