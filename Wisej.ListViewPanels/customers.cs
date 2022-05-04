using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wisej.ListViewPanels
{
    public class ProductModel
    {
        public string ProductTitle { get; set; }
        public bool InStock { get; set; }
        public decimal Price { get; set; }
        public string ProductDetail { get; set; }
        public string Image { get; set; }
    }
}