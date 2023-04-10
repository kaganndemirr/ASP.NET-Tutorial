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
    public class WriterController : Controller
    {

        readonly WriterManager _wm;

        readonly WriterValidation _wv;

        public WriterController()
        {
            _wm = new WriterManager(new EFWriterDAL());

            _wv = new WriterValidation();
        }

        // GET: Writer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetWriterList() 
        {
            var WriterList = _wm.GetWriters();
            return View(WriterList); 
        }

        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddWriter(Writer p)
        {
            ValidationResult results = _wv.Validate(p);
            if (results.IsValid)
            {
                _wm.AddWriter(p);
                return RedirectToAction("GetWriterList");
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

        public ActionResult DeleteWriter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateWriter(Writer p)
        {
            ValidationResult results = _wv.Validate(p);
            if (results.IsValid)
            {
                _wm.UpdateWriter(p);
                return RedirectToAction("GetWriterList");
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

        [HttpGet]
        public ActionResult UpdateWriter(int id)
        {
            var writerValue = _wm.GetById(id);
            return View(writerValue);
        }
    }
}