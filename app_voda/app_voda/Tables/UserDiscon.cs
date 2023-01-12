using System;
using System.Collections.Generic;
using System.Text;

namespace app_voda.Tables
{
    public class UserDiscon
    {
        public Guid NumDis { get; set; }
        public string StreetDis { get; set; }
        public string HouseDis { get; set; }
        public DateTime DateDis { get; set; }
        public string CommentDis { get; set; }
    }
}
