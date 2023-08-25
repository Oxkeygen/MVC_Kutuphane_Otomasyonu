using FluentValidation;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasyonu.Entities.Validations
{
    public class KullanicilarValidators:AbstractValidator<Kullanicilar>
    {
        public KullanicilarValidators()
        {

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Alanı Boş Geçilemez.");
            RuleFor(x => x.Email).MaximumLength(150).WithMessage("Email Alanı En Fazla 150 Karakter Olabilir.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Bir Mail Adresi Formatı Giriniz.");
            ////////////////

            RuleFor(x => x.AdiSoyadi).NotEmpty().WithMessage("Adı Soyadı Alanı Boş Geçilemez.");
            RuleFor(x => x.AdiSoyadi).MaximumLength(100).WithMessage("Adı Soyadı Alanı En Fazla 100 Karakter Olabilir.");
            RuleFor(x => x.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez.");
            RuleFor(x => x.KullaniciAdi).MaximumLength(30).WithMessage("Kullanıcı Alanı En Fazla 30 Karakter Olabilir.");

            RuleFor(x => x.Sifre).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez.");
            RuleFor(x => x.Sifre).MaximumLength(15).WithMessage("Şifre Alanı En Fazla 15 Karakter Olabilir.");

            RuleFor(x => x.Telefon).NotEmpty().WithMessage("Telefon Alanı Boş Geçilemez.");
            RuleFor(x => x.Telefon).MaximumLength(20).WithMessage("Telefon Alanı En Fazla 20 Karakter Olabilir.");

            RuleFor(x => x.Adres).NotEmpty().WithMessage("Adres Alanı Boş Geçilemez.");
            RuleFor(x => x.Adres).MaximumLength(500).WithMessage("AdresAlanı En Fazla 500 Karakter Olabilir.");
        }
    }
}
