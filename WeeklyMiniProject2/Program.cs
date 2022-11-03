
using WeeklyMiniProject2;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Welcome to your product list. Enter values below. When you are done enter q to quit");
Console.ForegroundColor = ConsoleColor.White;

string category;
string name;
int price;
bool breaker = false;
List<ProductList> productLists = new List<ProductList>();

void lineDivider()
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("-----------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.White;
}

void GetInfo()
{
    while (true)
    {

        Console.Write("Add product category: ");
        category = Console.ReadLine();
        if (category.Trim().ToLower() == "q")
        {
            break;
        }
        Console.Write("Add a product name: ");
        name = Console.ReadLine();
        if (name.Trim().ToLower() == "q")
        {
            break;
        }
        Console.Write("Add a product price: ");

        price = Convert.ToInt32(Console.ReadLine());
        if (price.ToString().Trim().ToLower() == "q")
        {
            break;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Succsefully added product to list");
        Console.ResetColor();
        productLists.Add(new ProductList { Category = category, Name = name, Price = price, });



    }

}

void DisplayList()
{

    lineDivider();
    int sum = productLists.Sum(product => product.Price);
    Console.WriteLine("Here is your list of products.Enter restart if you wish to enter additional products to the list");

    productLists.OrderByDescending(item => item.Price);
    foreach (var product in productLists)
    {
        Console.WriteLine("Category: ".PadRight(10) + product.Category);
        Console.WriteLine();
        Console.WriteLine("Name: ".PadRight(10) + product.Name);
        Console.WriteLine();
        Console.WriteLine("Price: ".PadRight(10) + product.Price);

    }
    Console.WriteLine();
    Console.WriteLine("Sum of price: ".PadRight(10) + sum);
    lineDivider();

}
GetInfo();
DisplayList();

string restart = Console.ReadLine();

