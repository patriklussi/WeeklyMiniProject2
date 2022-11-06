
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

void error(string errorMsg) //Error function to increase the understandability of the code
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine(errorMsg);
    Console.ResetColor();
}
void GetInfo()
{
    while (true)
    {

        bool isCorrect = true;
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


        bool checkIfNumber = int.TryParse(Console.ReadLine(), out price);
        if (!checkIfNumber)
        {
            error("You can only enter numbers or q here");
           
            isCorrect = false;
            continue;
        }

        if (price.ToString().Trim().ToLower() == "q")
        {
            break;
        } 


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Succsefully added product to list");
        Console.ResetColor();

        if (isCorrect)
        {
            productLists.Add(new ProductList { Category = category, Name = name, Price = price, });

        }



    }

}



while (true) // This while loop ensures that you can add more products if you want
{
    GetInfo();
    DisplayList.PrintList(productLists);
    string restart = Console.ReadLine();
    if(restart.Trim().ToLower() == "restart")
    {
        continue;

    } else

    {
        break;
    }
}





class DisplayList
{
    public  static void PrintList(List<ProductList> productLists)
    {
        int sum = productLists.Sum(product => product.Price);
        Console.WriteLine("Here is your list of products. Enter restart if you wish to enter additional products to the list");
        Console.WriteLine();

        List<ProductList> sortedList = productLists.OrderBy(item => item.Price).ToList();

        Console.WriteLine("Category".PadRight(10) + "Name".PadRight(10) + "Price".PadRight(10));
        foreach (var product in sortedList)
        {

            Console.WriteLine(product.Category.PadRight(10) + product.Name.PadRight(10) + product.Price.ToString().PadRight(10));

        }
        Console.WriteLine();
        Console.WriteLine("Sum of price: ".PadRight(10) + sum);
    }
}
