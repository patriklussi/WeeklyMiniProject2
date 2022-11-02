// See https://aka.ms/new-console-template for more information

using WeeklyMiniProject2;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Welcome to your product list. Enter values below. When you are done enter q to quit");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Hello from Visual studio");



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
productLists.Sort();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("---------------------------------");
Console.ForegroundColor = ConsoleColor.White;
foreach (var product in productLists)
{
    Console.WriteLine("Category: ".PadRight(10) + product.Category);
    Console.WriteLine("Name: ".PadRight(10) + product.Name);
    Console.WriteLine("Price: ".PadRight(10)+ product.Price);
}


string restart = Console.ReadLine();

if(restart == "Add more")
{
    products.AddProducts();
} else
{
    Console.WriteLine("Gay");
}



