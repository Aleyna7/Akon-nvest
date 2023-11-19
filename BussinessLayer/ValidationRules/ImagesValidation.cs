using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class ImagesValidation:AbstractValidator<Images>
    {
        public ImagesValidation()
        {
            RuleFor(x => x.ImageName).NotEmpty().WithMessage("Boş bırakılamaz");
            RuleFor(x => x.AdvertID).NotEmpty().WithMessage("İlan bilgisi boş bırakılmaz");
        }
    }
}
