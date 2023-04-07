using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        readonly ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void AddCategory(Category category)
        {
            _categoryDAL.Insert(category);

        }

        public void DeleteCategory(Category category)
        {
            _categoryDAL.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryDAL.Get(x => x.CategoryId == id);
        }

        public List<Category> GetCategories()
        {
            return _categoryDAL.List();
        }

        public void UpdateCategory(Category category)
        {
            _categoryDAL.Update(category);
        }
    }
}
