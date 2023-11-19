using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class DistrictValidation:AbstractValidator<District>
    {
        public DistrictValidation()
        {
            RuleFor(x=>x.DistrictName).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x=>x.CityId).NotEmpty().WithMessage("Şehir alanı boş bırakılamaz");

        }
    }
}
