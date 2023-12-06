using System.Text.Json;
using PetStore;

namespace PetStore
{
    public class Program
    {

        static void Main(string[] args)
        {
            var productLogic = new ProductLogic();
            ///ask to make new product
            Console.WriteLine("Press 1 to add a product, press 2 to look up product, press 3 to show instock products, press 4 to return total price of inventory");
            Console.WriteLine("Type 'exit' to quit");
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                ///confirm whether to make new product
                Console.WriteLine("Press 1 to add a product, press 2 to look up product, press 3 to show instock products, press 4 to return total price of inventory");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
                if (userInput == "2")
                {
                    ///ask for product to search for
                    Console.WriteLine("Type name of product");
                    userInput = Console.ReadLine();
                    ///return product asked for
                    var result = productLogic.GetCatFoodByName(userInput);
                    ///if null return error message, if product exists return product info
                    if (result == null)
                    {
                        Console.WriteLine("Product not Found");
                    }
                    else
                    {
                        Console.WriteLine(JsonSerializer.Serialize(productLogic.GetCatFoodByName(userInput)));
                    }
                }
                    
                ///if 1 create new catfood
                if (userInput == "1")
                {
                    ///ask type of product
                    Console.WriteLine("Type 1 for Canned Catfood or 2 for Dryfood");
                    userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        ///create new catfood object
                        CatFood catFood = new CatFood();
                        ///ask for name
                        Console.WriteLine("Type the name");
                        ///setting name of catfood to userinput
                        catFood.Name = Console.ReadLine();
                        ///ask for price
                        Console.WriteLine("What is the Price of the Product?");
                        ///set price, convert price into decimal using int.parse
                        catFood.Price = decimal.Parse(Console.ReadLine());
                        ///ask for quantity
                        Console.WriteLine("How many of this product do you have?");
                        ///setting Quantity, parse into int
                        catFood.Quantity = int.Parse(Console.ReadLine());
                        ///ask for description
                        Console.WriteLine("Add a description for your product");
                        ///set description
                        catFood.Description = Console.ReadLine();
                        ///ask if Kitten food
                        Console.WriteLine("Is this product Kitten Food? Type True or False");
                        ///set Kitten food to true or false
                        catFood.KittenFood = bool.Parse(Console.ReadLine());
                        ///add product to list
                        productLogic.AddProduct(catFood);
                        ///product added message
                        Console.WriteLine("Product info added " + JsonSerializer.Serialize(catFood));
                    }
                    if (userInput == "2")
                    {
                        ///create new catfood object
                        DryCatFood dryFood = new DryCatFood();
                        ///ask for name
                        Console.WriteLine("Type the name");
                        ///setting name of catfood to userinput
                        dryFood.Name = Console.ReadLine();
                        ///ask for price
                        Console.WriteLine("What is the Price of the Product?");
                        ///set price, convert price into decimal using int.parse
                        dryFood.Price = decimal.Parse(Console.ReadLine());
                        ///ask for quantity
                        Console.WriteLine("How many of this product do you have?");
                        ///setting Quantity, parse into int
                        dryFood.Quantity = int.Parse(Console.ReadLine());
                        ///ask for description
                        Console.WriteLine("Add a description for your product");
                        ///set description
                        dryFood.Description = Console.ReadLine();
                        ///ask weight of product
                        Console.WriteLine("How much does this product weigh?");
                        ///set weight
                        dryFood.WeightPounds = int.Parse(Console.ReadLine());
                        ///ask if Kitten food
                        Console.WriteLine("Is this product Kitten Food? Type True or False");
                        ///set Kitten food to true or false
                        dryFood.KittenFood = bool.Parse(Console.ReadLine());
                        ///add product to list
                        productLogic.AddProduct(dryFood);
                        ///product added message
                        Console.WriteLine("Product info added " + JsonSerializer.Serialize(dryFood));
                    }

                }
                //show all instock products
                if (userInput == "3")
                {
                    Console.WriteLine(JsonSerializer.Serialize(productLogic.GetOnlyInStockProducts()));
                }
                if (userInput == "4")
                {
                    Console.WriteLine(productLogic.GetTotalPriceOfInventory());
                }
            }
        }
    }
}


                
           

   
    