using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        readonly CategoryManager _cm;

        CategoryValidation categoryValidation;

        public CategoryController()
        {
            _cm = new CategoryManager(new EFCategoryDAL());

            categoryValidation = new CategoryValidation();
        }
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var CategoryValues = _cm.GetCategories();
            return View(CategoryValues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            ValidationResult results = categoryValidation.Validate(p);
            if (results.IsValid)
            {
                _cm.AddCategory(p);
                return RedirectToAction("GetCategoryList");
            }
            else 
            {
               foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                } 
            }
            return View();
            
        }

        public ActionResult DeleteCategory(int id) 
        {
            var categoryValue = _cm.GetById(id);
            _cm.DeleteCategory(categoryValue);
            return RedirectToAction("GetCategoryList");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id) 
        {
            var categoryValue = _cm.GetById(id);
            return View(categoryValue);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            ValidationResult results = categoryValidation.Validate(category);
            if (results.IsValid)
            {
                _cm.UpdateCategory(category);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}