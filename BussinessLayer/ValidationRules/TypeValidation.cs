using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class TypeValidation:AbstractValidator<EntityLayer.Entities.Type>
    {
        public TypeValidation()
        {
            RuleFor(x=>x.TypeName).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.SituationId).NotEmpty().WithMessage("Durum alanı boş bırakılamaz");
        }
    }
}
