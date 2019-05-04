using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWorkShop1.Models
{
    public class Book_Code
    {
        [Required()]
        public string CodeType { get; set; }
        [Required()]
        public string CodeId { get; set; }
        [DisplayName("CodeType描述")]
        public string CodeTypeDesc { get; set; }
        [DisplayName("CodeID描述")]
        public string CodeName { get; set; }
        public string CreateUser { get; set; }
        public string CreateDate { get; set; }
        public string ModifyDate { get; set; }
        public string ModifyUser { get; set; }
    }
    class Code
    {
        static void Main(string[] args)
        {
            IList<Book_Code> orders = new List<Book_Code>()
            {
                new Book_Code()
                {
                   CodeType = "可以借出",
                   CodeId = "A"
                },
                new Book_Code()
                {
                    CodeType = "已借出",
                    CodeId = "B"
                },
                new Book_Code()
                {
                   CodeType = "不可借出",
                   CodeId = "U"
                },
                new Book_Code()
                {
                    CodeType = "已借出(未領)",
                    CodeId = "C"
                }
            };
        }
    }
}