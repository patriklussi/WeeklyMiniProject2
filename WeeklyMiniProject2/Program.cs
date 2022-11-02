// See https://aka.ms/new-console-template for more information

using WeeklyMiniProject2;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Welcome to your product list. Enter values below. When you are done enter q to quit");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Hello from Visual studio");


string category;
string name;
int price;


void GetInfo()
{
    Console.Write("Add product category: ");
    category = Console.ReadLine();

    Console.Write("Add a product name: ");
    name = Console.ReadLine();

    Console.Write("Add a product price: ");
    price = Convert.ToInt32(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Succsefully added product to list");
    Console.ResetColor();

}

List<ProductList> productLists = new List<ProductList>();

while (true)
{
    GetInfo();
    productLists.Add(new ProductList { Category = category,Name = name,Price = price, });
    string data = Console.ReadLine();

    if(data.Trim().ToLower() == "q"){
        break;
    }
}
  
Console.WriteLine("Exited");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("---------------------------------");
Console.ForegroundColor = ConsoleColor.White;
foreach (var product in productLists)
{
    Console.WriteLine("Category: ".PadRight(10) + product.Category);
    Console.WriteLine("Name: ".PadRight(10) + product.Name);
    Console.WriteLine("Price: ".PadRight(10)+ product.Price);
}




Console.ReadLine();

