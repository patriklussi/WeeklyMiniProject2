using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyMiniProject2
{
    internal class ProductList
    {
        public ProductList()
        {
        }

        public ProductList(string category, string name, int price, bool breaker)
        {
            Category = category;
            Name = name;
            Price = price;
            Breaker = breaker;  
        }

        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Breaker = false;

      public  void AddProducts()
        {
            Console.Write("Add product category: ");
            this.Category = Console.ReadLine();

            Console.Write("Add a product name: ");
            this.Name = Console.ReadLine();

            Console.Write("Add a product price: ");
            this.Price = Convert.ToInt32(Console.ReadLine());

     
            

        }
    }
}
