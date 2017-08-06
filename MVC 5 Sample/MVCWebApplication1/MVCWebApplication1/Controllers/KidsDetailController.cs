using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebApplication1.Models;
using MVCWebApplication1.ViewModel;

namespace MVCWebApplication1.Controllers
{
    public class KidsDetailController : Controller
    {
        // GET: KidsDetail
        public ActionResult GetListKids()
        //public ViewResult GetListKids()
        {
            KidsDetail kidsDetail = new KidsDetail
            {
                Name = "Rishabh Mahawar",
                Age = 2,
                Address = "Jabalpur",
                Gender = "Male"
            };

            var danceActivity = new List<DanceActivity>
            {
                new DanceActivity {Name ="Rock",DurationInDays = 10,Level = "Beginner"},
                new DanceActivity { Name ="Salsa", DurationInDays = 30, Level = "Advances"}
            };
            KidsDanceActivity kidsDanceActivity = new KidsDanceActivity
            {
                KidsDetail = kidsDetail,
                DanceActivities = danceActivity
            };


            // ViewData["kids"] = kidsDetail;
            //ViewBag.kids = kidsDetail;
            return View(kidsDanceActivity);
            //return View (kidsDetail );
            //return new ViewResult();
            //return Content("HI Vivek");
            //return Json(kidsDetail,JsonRequestBehavior.AllowGet);
            //return HttpNotFound();
            //return new EmptyResult();
            // return RedirectToAction("Index", "Home", new {Page = 5});//3rd argument is just anonymous object(passed as query string parameters)

        }


        public ActionResult Edit(string kidid)
        {
            return Content(kidid);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrEmpty(sortBy))
                sortBy = "asc";
            return Content($"pageindex {pageIndex}, sort by {sortBy}");

        }

        //custom route example
        public ActionResult KidByNameAge(string name, int age)
        {
            return Content(name + "/" + age);
        }

    }
}