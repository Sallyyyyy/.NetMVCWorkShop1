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
            Book_Data bookData = new Book_Data();
            IList<Book_Data> bookDataList = new Book_Data().GetBooks();
            Book_Class bookClass = new Book_Class();
            //IList<Book_Class> bookClassList = new Book_Class().GetBookClass();
            ViewBag.BooksList = bookDataList;
            //ViewBag.BookClassList = bookClassList;
            return View();
        }
        
        //查詢頁面
        public ActionResult Search()
        {
            Models.Book_Class bookclass = new Models.Book_Class();
            IList<Book_Class> bookClassList = new Book_Class().GetBookClass().ToList();
            List<SelectListItem> selectClassList = new List<SelectListItem>();
            for(int i=0;i< bookClassList.Count; i++)
            {
                selectClassList.Add(new SelectListItem()
                {
                    Value = (bookClassList[i].BookClassId).ToString(),
                    Text = (bookClassList[i].BookClassName).ToString()
                });
            }
            
            ViewBag.SelectClassList = selectClassList;
            return View();
        }
        //查詢功能
        [HttpPost]
        public ActionResult Search(Book_Class bookclass)
        {
            Console.WriteLine("123123");
            Book_Data bookData = new Book_Data();
            IList<Book_Data> bookDataList = new Book_Data().GetBooks();
            IList<SelectListItem> booksList = new List<SelectListItem>();
            var newList = bookDataList.Where(x => x.BookClassId.Equals(bookclass.BookClassName)).ToList();
            foreach (var item in newList.ToList())
            {
                booksList.Add(new SelectListItem()
                {
                    Value = item.BookClassId,
                    Text = item.BookName
                });
            }
            Console.WriteLine(newList.Count.ToString());
            ViewBag.SelectClassList = booksList;
            if(booksList != null)
            {
                string x = "";
                for (int i=0;i< booksList.Count;i++)
                {
                   
                    x += booksList[i].Text + " ";
                }
                return Content(x);

            }
            else
            {
                return Content("查無資料");
            }
            
        }
        //新增書籍畫面
        public ActionResult InsertBook()
        {
            ViewBag.Insert = "Insert";
            return View();
        }
        //新增書籍功能
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