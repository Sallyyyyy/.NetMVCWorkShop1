using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWorkShop1.Models;

namespace MVCWorkShop1.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
        public ActionResult Index()
        {
            Book_Data bookdata = new Book_Data();
            IList<Book_Data> list = new Book_Data().Main();
            ViewBag.BookList = list;
            return View(bookdata);
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
        [HttpPost]
        public ActionResult InsertBook(Book_Data bookdata)
        {
            int a = bookdata.BookId;
            ViewBag.Insert = "Insert";
            TempData["message"] = "存檔成功";
            return View(bookdata);
        }


    }
}