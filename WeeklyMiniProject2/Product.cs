using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyMiniProject2
{
    internal class Product
    {
        
        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    
       

       public string ToString()
        {
            return this.Category.PadRight(10) + this.Name.PadRight(10) + this.Price.ToString().PadRight(10);
        }
    }
    
}
