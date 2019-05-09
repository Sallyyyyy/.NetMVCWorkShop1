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
            List<SelectListItem> selectClassList = new List<SelectListItem>();
            IList<Book_Class> bookClassList = new Book_Class().GetBookClass().ToList();
            for (int i = 0; i < bookClassList.Count; i++)
            {
                selectClassList.Add(new SelectListItem()
                {
                    Value = (bookClassList[i].BookClassId).ToString(),
                    Text = (bookClassList[i].BookClassName).ToString()
                });
            }
            ViewBag.SelectClassList = selectClassList; //下拉式選單
            ViewBag.BooksList = bookDataList;  //書籍資料清單
            return View();
        }
        //查詢功能
        [HttpPost]
        public ActionResult Index(Book_Class bookclass,Book_Data books)
        {
            IList<Book_Data> bookDataList = new Book_Data().GetBooks();
            IList<Book_Data> newList = bookDataList.Where(x => x.BookClassId.Equals(bookclass.BookClassName)).ToList();
            ViewBag.BooksList = newList;
            //查詢的下拉式選單
            List<SelectListItem> selectClassList = new List<SelectListItem>();
            IList<Book_Class> bookClassList = new Book_Class().GetBookClass().ToList();
            for (int i = 0; i < bookClassList.Count; i++)
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

        //新增書籍畫面
        public ActionResult InsertBook()
        {
            IList<Book_Class> bookClassList = new Book_Class().GetBookClass();
            List<SelectListItem> selectClassList = new List<SelectListItem>();
            for (int i = 0; i < bookClassList.Count; i++)
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
        //新增書籍功能
        [HttpPost]
        public ActionResult InsertBook(Book_Data bookdata)
        {
            //查詢的下拉式選單
            List<SelectListItem> selectClassList = new List<SelectListItem>();
            IList<Book_Class> bookClassList = new Book_Class().GetBookClass().ToList();
            for (int i = 0; i < bookClassList.Count; i++)
            {
                selectClassList.Add(new SelectListItem()
                {
                    Value = (bookClassList[i].BookClassId).ToString(),
                    Text = (bookClassList[i].BookClassName).ToString()
                });
            }
            ViewBag.SelectClassList = selectClassList;
            //新增
            IList<Book_Data> bookList = new Book_Data().GetBooks();
            bookList.Add(new Book_Data() {
                BookId = bookdata.BookId,
                BookName = bookdata.BookName,
                BookClassId = bookdata.BookClassId,
                BookAuthor = bookdata.BookAuthor,
                BookBoughtDate = bookdata.BookBoughtDate,
                BookPublisher = bookdata.BookPublisher,
                BookNote = bookdata.BookNote,
                BookStatus = "可以借出"
            });
            ViewBag.BooksList = bookList;
            return View("Index");
        }
        public ActionResult DeleteBook(Book_Data bookdata)
        {
            IList<Book_Data> bookList = new Book_Data().GetBooks();
            bookList.Remove(new Book_Data() { BookId =  bookdata.BookId});

            //查詢的下拉式選單
            List<SelectListItem> selectClassList = new List<SelectListItem>();
            IList<Book_Class> bookClassList = new Book_Class().GetBookClass().ToList();
            for (int i = 0; i < bookClassList.Count; i++)
            {
                selectClassList.Add(new SelectListItem()
                {
                    Value = (bookClassList[i].BookClassId).ToString(),
                    Text = (bookClassList[i].BookClassName).ToString()
                });
            }
            ViewBag.SelectClassList = selectClassList;
            ViewBag.BooksList = bookList;
            return View("Index");
        }
        public ActionResult UpdateBook(Book_Data bookdata)
        {
            return Content("UpdateBook");
        }


    }
}