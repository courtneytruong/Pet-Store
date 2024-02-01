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
using PetStore.Data;

namespace Pet_Store_class_exercise;

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


            if (userInput == "1")
            {
                //MenuLogic.ConfirmProductType();
                //create product object using json format
                Console.WriteLine("Please add a Product in JSON format");
                var userInputAsJson = Console.ReadLine();
                var product = JsonSerializer.Deserialize<ProductEntity>(userInputAsJson);
                //add product to database                      
                productLogic?.AddProduct(product);
                
                Console.WriteLine("Product info added " + JsonSerializer.Serialize(product));

            
                //if (userInput == "1")
                //{
                //create wet cat food object using json format
                //Console.WriteLine("Please add a Cat Food in JSON format");
                //var userInputAsJson = Console.ReadLine();
                //var catFood = JsonSerializer.Deserialize<CatFood>(userInputAsJson);
                //add product to list                      
                //productLogic.AddProduct(catFood);
                //Console.WriteLine("Product info added " + JsonSerializer.Serialize(catFood));
                //}


            }

            if (userInput == "2")
            {
                //ask for product to search for
                Console.WriteLine("Type ID of product");
                userInput = Console.ReadLine();
                var productID = int.Parse(Console.ReadLine());
                //return product asked for
                var result = productLogic?.GetProductByID(productID);
                ///if null return error message, if product exists return product info
                if (result == null)
                {
                    Console.WriteLine("Product not Found");
                }
                else
                {
                 Console.WriteLine(JsonSerializer.Serialize(productLogic.GetProductByID(productID)));
                }
            }

            if (userInput == "3")
            {
                Console.WriteLine("Add an Order in Json format");
                    var userInputAsJson = Console.ReadLine();
                var order = JsonSerializer.Deserialize<OrderEntity>(userInputAsJson);
                //add order to database                     
                productLogic?.AddOrder(order);
                Console.WriteLine("Order info added " + JsonSerializer.Serialize(order));
            }

            if (userInput == "4")
            {
                Console.WriteLine("Type ID of order");
                userInput = Console.ReadLine();
                var orderID = int.Parse(Console.ReadLine());
                //return product asked for
                var result = productLogic?.GetOrderByID(orderID);
                ///if null return error message, if product exists return product info
                if (result == null)
                {
                    Console.WriteLine("Order not Found");
                }
                else
                {
                    Console.WriteLine(JsonSerializer.Serialize(productLogic.GetOrderByID(orderID)));
                }
            }
            
        }

    }
    public static IServiceProvider CreateServiceCollection()
    {
        return new ServiceCollection()
              .AddTransient<IProductLogic, ProductLogic>()
              .AddTransient<IProductRepository, ProductRepository>()
              .AddTransient<IOrderRepository, OrderRepository>()
              .AddDbContext<ProductContext>()
              .BuildServiceProvider();
    } 
}







