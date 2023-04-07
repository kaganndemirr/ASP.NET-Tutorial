using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidation: AbstractValidator<Category>
    {
        public CategoryValidation() 
        { 
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Olamaz!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adı 3 Karakterden Az Olamaz!");

            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori Açıklaması Boş Olamaz!");
        }
    }
}
