using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project6.Models
{
    public class products
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string price { get; set; }

        public int quantity { get; set; }

        public string category { get; set; }

        public string imageurl { get; set; }
    }
}