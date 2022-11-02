// See https://aka.ms/new-console-template for more information

using WeeklyMiniProject2;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Welcome to your product list. Enter values below. When you are done enter q to quit");
Console.ForegroundColor = ConsoleColor.White;


string data;
string name = string.Empty;
string category = string.Empty;
int price = 0;


ProductList products = new ProductList();


products.AddProducts();


//while (true)
//{


//    products.AddProducts();
//    //Console.WriteLine(products.Breaker);
//    if (products.Breaker)
//   {
//       break;
//   }

   

//    Console.WriteLine(products.Price);

//}
Console.WriteLine("Exited");


List<ProductList> productLists = new List<ProductList>();

productLists.Add(products);

foreach(var product in productLists)
{
    Console.WriteLine(product.Category);
}


Console.ReadLine();
