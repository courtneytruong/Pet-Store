using PetStore;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Collections.Concurrent;
using Pet_Store_class_exercise;

namespace PetStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            var productLogic = new ProductLogic();
            ///ask to make new product
            Console.WriteLine("Press 1 to add a product or press 2 to look up product");
            Console.WriteLine("Type 'exit' to quit");
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                ///confirm whether to make new product
                Console.WriteLine("Press 1 to add a product or press 2 to look up product");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
                ///if 1 create new catfood
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
                    ///ask for weight in pounds of product
                    Console.WriteLine("How many pounds does this product weigh?");
                    ///set weight of product in lbs
                    catFood.WeightPounds = int.Parse(Console.ReadLine());
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
            }
        }
    }
}
   
    