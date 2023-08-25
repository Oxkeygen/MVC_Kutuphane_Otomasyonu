using FluentValidation;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasyonu.Entities.Validations
{
    public class DuyurularValidator:AbstractValidator<Duyurular>
    {
        public DuyurularValidator()
        {
            RuleFor(x => x.Baslik).NotEmpty().WithMessage("Başlık Alanı Boş Geçilemez");
            RuleFor(x => x.Duyuru).NotEmpty().WithMessage("Duyuru Alanı Boş Geçilemez");
            RuleFor(x => x.Baslik).Length(5, 150).WithMessage("Başlık ALanı 5-150 Karakter Arasında Olmalıdır ");
            RuleFor(x => x.Duyuru).MaximumLength(500).WithMessage("Duyuru Alanı En Fazla 500 Karakter Arasında Olmalıdır ");
            
           
        }

    }
}
