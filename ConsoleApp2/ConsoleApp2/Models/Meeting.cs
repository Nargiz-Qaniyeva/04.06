using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    class Meeting
    {
       
        public string  FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string  Name { get; set; }
        public Meeting()
        {
            this.FromDate = FromDate;
            this.ToDate = ToDate;
            this.Name = Name;
        }

    }
}
