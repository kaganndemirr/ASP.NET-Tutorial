using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        readonly HeadingManager _hm;
        readonly CategoryManager _cm;

        public HeadingController()
        {
            _hm = new HeadingManager(new EFHeadingDAL());
            _cm = new CategoryManager(new EFCategoryDAL());
        }

        // GET: Heading
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetHeadingList()
        {
            var headingValues = _hm.GetHeadings();
            return View(headingValues);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valueCategory = (from x in _cm.GetCategories()
                                                  select new SelectListItem
                                                  {
                                                    Text = x.CategoryName,
                                                    Value = x.CategoryId.ToString()
                                                  }).ToList();
            ViewBag.vlc = valueCategory;
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            heading.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());

            _hm.AddHeading(heading);
            return RedirectToAction("GetHeadingList");
        }
    }
}