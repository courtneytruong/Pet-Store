using Pet_Store_class_exercise;
using PetStoreProducts;
using PetStoreProductLogic;
using System.Collections.Generic;
using System.Text.Json;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace PetStoreUI
{
    public class CatFoodMenuUI ///creates menu for catfood products
    {

        public static DryCatFood DryCatFoodMenuLogic() /// creates dry food product menu
        {
            
            DryCatFood dryFood = new DryCatFood();
            
            Console.WriteLine("Type the name");
            dryFood.Name = Console.ReadLine();
            
            Console.WriteLine("What is the Price of the Product?");
            dryFood.Price = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("How many of this product do you have?");
            dryFood.Quantity = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Add a description for your product");
            dryFood.Description = Console.ReadLine();
           
            Console.WriteLine("How much does this product weigh?");
            dryFood.WeightPounds = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Is this product Kitten Food? Type True or False");            
            dryFood.KittenFood = bool.Parse(Console.ReadLine());

            return (dryFood);
        }
    }
}
