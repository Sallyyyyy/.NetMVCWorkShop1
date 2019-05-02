using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWorkShop1.Models
{
    public class Book_Data
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookClassId { get; set; }
        public string BookAuthor { get; set; }
        public string BookBoughtDate { get; set; }
        public string BookPublisher { get; set; }
        public string BookNote { get; set; }
        public string BookStatus { get; set; }
        public string BookKeeper { get; set; }
        public string CreateDate { get; set; }
        public string CreateUser { get; set; }
        public string ModifyDate { get; set; }
        public string ModifyUser { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Book_Data> orders = new List<Book_Data>()
            {
                new Book_Data()
                {
                    BookId = 1,
                    BookName = "在顛沛流離的世界你還有我啊",
                    BookClassId = "Life",
                    BookAuthor = "PeterSu",
                    BookBoughtDate = "2018/12/25",
                    BookPublisher = "春風出版",
                    BookNote = "關於旅行",
                    BookStatus = "可以借出"
                },
                new Book_Data()
                {
                    BookId = 2,
                    BookName = "表白",
                    BookClassId = "Love",
                    BookAuthor = "Dorothy",
                    BookBoughtDate = "2018/12/25",
                    BookPublisher = "春風出版",
                    BookNote = "那些說不口的話",
                    BookStatus = "可以借出"
                },
                new Book_Data()
                {
                    BookId = 3,
                    BookName = "鈕扣",
                    BookClassId = "Love",
                    BookAuthor = "Dorothy",
                    BookBoughtDate = "2018/12/25",
                    BookPublisher = "春風出版",
                    BookNote = "你是因為，你是所以",
                    BookStatus = "可以借出"
                },
                new Book_Data()
                {
                    BookId = 4,
                    BookName = "為你自己活一次",
                    BookClassId = "Life",
                    BookAuthor = "蔡康永",
                    BookBoughtDate = "2018/12/25",
                    BookPublisher = "春風出版",
                    BookNote = "蔡康永人生體悟",
                    BookStatus = "可以借出"
                },
                new Book_Data()
                {
                    BookId = 5,
                    BookName = "如果可以簡單誰想要複雜",
                    BookClassId = "Life",
                    BookAuthor = "PeterSu",
                    BookBoughtDate = "2018/12/25",
                    BookPublisher = "春風出版",
                    BookNote = "關於旅行",
                    BookStatus = "可以借出"
                }
            };
        }
    }
}