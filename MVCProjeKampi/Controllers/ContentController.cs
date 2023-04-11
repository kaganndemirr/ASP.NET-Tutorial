using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        readonly ContentManager _cm;

        ContentValidation categoryValidation;

        public ContentController()
        {
            _cm = new ContentManager(new EFContentDAL());

            categoryValidation = new ContentValidation();
        }

        // GET: Content
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContentByHeading(int id)
        {
            var ContentValues = _cm.GetListByHeadingId(id);
            return View(ContentValues);
        }
    }
}