using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class GeneralSettingsValidation:AbstractValidator<GeneralSettings>
    {
        public GeneralSettingsValidation()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.PhoneNumber).Matches(new Regex(@"([\+]90?)(\d{3})(\s*[\-?])(\d{2})(\s*[\-]?)(\d{2})"));
            RuleFor(x=>x.ImageName).NotEmpty().WithMessage("Boş Bırakılamaz");
        }
    }
}
