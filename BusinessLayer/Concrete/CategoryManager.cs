using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            this.categoryDAL = categoryDAL;
        }

        public void AddCategory(Category category)
        {
            this.categoryDAL.Create(category);
        }

        public void UpdateCategory(Category category)
        {
            this.categoryDAL.Update(category);
        }

        public void DeleteCategory(Category category)
        {
            this.categoryDAL.Remove(category);
        }   

        public List<Category> GetAllCategories()
        {
            return this.categoryDAL.GetAll();
        }

        public Category GetById(int id)
        {
            return this.categoryDAL.GetById(id);
        }
    }
}
