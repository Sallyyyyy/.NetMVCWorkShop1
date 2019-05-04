using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWorkShop1.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
        public ActionResult Index()
        {
            Models.Book_Data bookdata = new Models.Book_Data();
            return View();
        }
        public ActionResult Search()
        {
            Models.Book_Class bookclass = new Models.Book_Class();
            List<SelectListItem> bookclasslist = new List<SelectListItem>();

            ViewBag.BookClassList = bookclasslist;
            return View(bookclass);
        }
        public ActionResult InsertBook()
        {
            ViewBag.Insert = "Insert";
            return View();
        }


    }
}