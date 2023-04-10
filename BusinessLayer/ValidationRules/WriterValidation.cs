using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidation: AbstractValidator<Writer>
    {
        public WriterValidation() 
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş Olamaz!");
            RuleFor(x => x.WriterLastName).MinimumLength(2).WithMessage("Yazar Soyadı Boş Olamaz!");
        }
    }
}
