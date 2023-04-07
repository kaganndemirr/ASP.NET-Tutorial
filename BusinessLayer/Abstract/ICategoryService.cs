using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{

    internal interface ICategoryService
    {
        List<Category> GetCategories();
        void AddCategory(Category category);

        Category GetById(int id);

        void DeleteCategory(Category category);

        void UpdateCategory(Category category);
    }
}
