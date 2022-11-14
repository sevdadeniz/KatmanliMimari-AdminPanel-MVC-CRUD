using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeacherValidator : AbstractValidator<Teacher>
    {

        public TeacherValidator()
        {
            RuleFor(x => x.TName).NotEmpty().WithMessage("Öğretmen ismi boş geçilemez");
        }

    }
}
