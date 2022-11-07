using WeeklyMiniProject2;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Welcome to your product list. Enter values below. When you are done enter q to quit");
Console.ForegroundColor = ConsoleColor.White;

string category;
string name;
int price;

ProductList productList = new ProductList();

void lineDivider() // Function to print decorational lines
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

void GetInfo() //Function to capture user input and information 
{
    while (true)
    {

        bool isCorrect = true;
        Console.Write("Add product category: ");
        category = Console.ReadLine();
        if (category.Trim().ToLower() == "q") break; //Checks if user typed Q to exit
        

        Console.Write("Add a product name: ");
        name = Console.ReadLine();
        if (name.Trim().ToLower() == "q") break; //Checks if user typed Q to exit

        Console.Write("Add a product price: ");

        bool checkIfNumber = int.TryParse(Console.ReadLine(), out price); //Checks if price is number
        if (!checkIfNumber)
        {
            error("You can only enter numbers or q here");
            isCorrect = false;
            continue;
        }

        if (price.ToString().Trim().ToLower() == "q") break; //Checks if user typed Q to exit


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Succsefully added product to list");
        Console.ResetColor();

        if (isCorrect)
        {
            productList.AddProduct(category,name,price);
        }
    }
}

while (true) //Main loop that runs the program
{
    GetInfo();
    lineDivider();
    productList.PrintProducts();
    lineDivider();
    Console.WriteLine("Enter P if you wish to add additional products to the list "); // I was going to add the search function but it did not end up happening
    string restart = Console.ReadLine();

    if(restart.Trim().ToUpper() == "P")
    {
        continue;
    } else
    {
        Console.WriteLine("Thank you for using this product lister");
        break;
    }
}


class ProductList // Productlist class used to add information to the product list and then prin the information
{

    List<Product> productLists = new List<Product> ();
    public  void PrintProducts() // Prints products to the console
    {
        int sum = productLists.Sum(product => product.Price); //Sums up the prices of the added products

        Console.WriteLine("Here is your list of products");

        Console.WriteLine();

        List<Product> sortedList = productLists.OrderBy(item => item.Price).ToList(); //Sorts products from lowest to highest

        Console.WriteLine("Category".PadRight(10) + "Name".PadRight(10) + "Price".PadRight(10));
        foreach (var product in sortedList)
        {
          Console.WriteLine(product.ToString()); //This function uses the Product method ToString 
        }
        Console.WriteLine();
        Console.WriteLine("Sum of price: ".PadRight(10) + sum);
    }
  public void AddProduct(string category, string name, int price) // Adds product to the product list
    {
        productLists.Add(new Product { Category = category, Name = name, Price = price }); //Adds a new Product object to the product list
    }
}
