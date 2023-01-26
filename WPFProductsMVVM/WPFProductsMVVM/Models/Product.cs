using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProductsMVVM.Models
{
    public class Product
    {
        public string? Title { get; set; }
        public string? Country { get; set; }
        public int Price { get; set; }
        public string? Image { get; set; }

        public override string ToString()
        {
            return $"{Title} -> {Price}";
        }
    }
}
