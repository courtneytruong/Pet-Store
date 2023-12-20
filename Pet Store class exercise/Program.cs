using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using PetStoreUI;
using PetStoreProductLogic;
using PetStoreProducts;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Cryptography.X509Certificates;

namespace Pet_Store_class_exercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var services = CreateServiceCollection();
            var productLogic = services.GetService<IProductLogic>();
            MenuLogic.WriteStartMenu();
            string userInput = Console.ReadLine();

            while (userInput?.ToLower() != "exit")
            {
                MenuLogic.WriteConfirmMenu();
                userInput = Console.ReadLine();

                ///add product TODO: fix logic for loop for dryfood
                if (userInput == "1")
                {
                    MenuLogic.ConfirmProductType();
                    userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                        //create wet cat food object using json format
                        Console.WriteLine("Please add a Cat Food in JSON format");
                        var userInputAsJson = Console.ReadLine();
                        var catFood = JsonSerializer.Deserialize<CatFood>(userInputAsJson);
                        //add product to list                      
                        productLogic.AddProduct(catFood);
                        Console.WriteLine("Product info added " + JsonSerializer.Serialize(catFood));
                    }

                    if (userInput == "2")
                    {
                        ///create new catfood object
                        DryCatFood dryFood = new DryCatFood();
                        dryFood = CatFoodMenuUI.DryCatFoodMenuLogic();
                        ///add product to list
                        productLogic.AddProduct(dryFood);
                        ///product added message
                        Console.WriteLine("Product info added " + JsonSerializer.Serialize(dryFood));
                    }
                }

                if (userInput == "2")
                {
                    //ask for product to search for
                    Console.WriteLine("Type name of product");
                    userInput = Console.ReadLine();
                    //return product asked for
                    var result = productLogic.GetProductByName<CatFood>(userInput);
                    ///if null return error message, if product exists return product info
                    if (result == null)
                    {
                        Console.WriteLine("Product not Found");
                    }
                    else
                    {
                        Console.WriteLine(JsonSerializer.Serialize(productLogic.GetProductByName<CatFood>(userInput)));
                    }
                }
                ///show all instock products
                if (userInput == "3")
                {
                    Console.WriteLine(JsonSerializer.Serialize(productLogic?.GetOnlyInStockProducts()));
                }
                ///get total price of inventory
                if (userInput == "4")
                {
                    Console.WriteLine(productLogic.GetTotalPriceOfInventory());
                }
            }

        }
        public static IServiceProvider CreateServiceCollection()
        {
            return new ServiceCollection()
                  .AddTransient<IProductLogic, ProductLogic>()
                  .BuildServiceProvider();
        } 
    }
}







