using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcStudent.Models
{
    public class ItemModel
    {
        public int ITEMS_ID { get; set; }
        public string ITEMS_Name { get; set; }
        public string ITEMS_Type { get; set; }
        public string ITEMS_PreprationTime { get; set; }
        public double ITEMS_Price { get; set; }
        public string ITEMS_Available { get; set; }
        public int CATEGORY_ID { get; set; }
    }
}