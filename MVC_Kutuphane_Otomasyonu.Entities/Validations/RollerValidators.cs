using FluentValidation;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasyonu.Entities.Validations
{
    public class RollerValidators:AbstractValidator<Roller>
    {
        public RollerValidators()
        {
            RuleFor(x => x.Rol).NotEmpty().WithMessage("Rol Alanı Boş Geçilemez.");
            RuleFor(x => x.Rol).MaximumLength(50).WithMessage("Rol Alanı En Fazla 50 Karakter Olabilir.");
        }
    }
}
