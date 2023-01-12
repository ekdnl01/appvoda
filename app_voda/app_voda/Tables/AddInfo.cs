using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace app_voda.Tables
{

    public class InfoList
    {
        [PrimaryKey, AutoIncrement, Column("_num")]
        public int Number { get; set; }

        public string Street { get; set; }
        public string House { get; set; }
        public string Reason { get; set; }
        public string Date { get; set; }
    }
}
