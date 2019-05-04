using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWorkShop1.Models
{
    public class Book_Class
    {
        [DisplayName("書籍類別編號")]
        [Required()]
        public string BookClassId { get; set; }
        [DisplayName("書籍類別名稱")]
        [Required()]
        public string BookClassName { get; set; }
        public string CreateUser { get; set; }
        public string CreateDate { get; set; }
        public string ModifyDate { get; set; }
        public string ModifyUser { get; set; }
    }
    class Class
    {
        static void Main(string[] args)
        {
            IList<Book_Class> orders = new List<Book_Class>()
            {
                new Book_Class()
                {
                   BookClassId = "Life",
                   BookClassName = "生活類"
                },
                new Book_Class()
                {
                    BookClassId = "Love",
                    BookClassName = "愛情類"
                },
                new Book_Class()
                {
                    BookClassId = "Language",
                    BookClassName = "語言類"
                },
                new Book_Class()
                {
                    BookClassId = "Magazine",
                    BookClassName = "雜誌類"
                },
                new Book_Class()
                {
                    BookClassId = "Education",
                    BookClassName = "教育類"
                }
            };
        }
    }
}