using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWorkShop1.Models
{
    public class Member_M
    {
        public string UserID { get; set; }
        public string UserCName { get; set; }
        public string UserEName { get; set; }
        public string CreateUser { get; set; }
        public string CreateDate { get; set; }
        public string ModifyDate { get; set; }
        public string ModifyUser { get; set; }
    }
    class user
    {
        IList<Member_M> orders = new List<Member_M>()
            {
                new Member_M()
                {
                   UserID = "001",
                   UserCName = "康小瑄",
                   UserEName = "Jenny"
                },
                new Member_M()
                {
                   UserID = "002",
                   UserCName = "李小璇",
                   UserEName = "Sally"
                },
                new Member_M()
                {
                   UserID = "003",
                   UserCName = "林小春",
                   UserEName = "Vivian"
                },
                new Member_M()
                {
                   UserID = "004",
                   UserCName = "徐小猩",
                   UserEName = "Jassica"
                },
                new Member_M()
                {
                   UserID = "005",
                   UserCName = "許小瑜",
                   UserEName = "Hs"
                }
            };
    }
}
}