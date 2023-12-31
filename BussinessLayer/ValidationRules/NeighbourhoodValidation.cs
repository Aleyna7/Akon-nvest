﻿using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class NeighbourhoodValidation:AbstractValidator<Neighbourhood>
    {
        public NeighbourhoodValidation()
        {
            RuleFor(x=>x.NeighbourhoodName).NotEmpty().WithMessage("Boş bırakılamaz");
            RuleFor(x => x.DistrictId).NotEmpty().WithMessage("Boş bırakılamaz");
        }
    }
}
