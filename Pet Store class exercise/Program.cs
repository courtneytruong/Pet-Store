using System;
using System.Text.Json;

namespace PetStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ask to make new product
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                //confirm whether to make new product
                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
                //if 1 create new catfood
                if (userInput == "1")
                {
                    //create new catfood object
                    CatFood catFood = new CatFood();
                    //ask for name
                    Console.WriteLine("Type the name");
                    //setting name of catfood to userinput
                    catFood.Name = Console.ReadLine();
                    //ask for price
                    Console.WriteLine("What is the Price of the Product?");
                    //set price, research convert price into decimal using int.parse
                    catFood.Price = decimal.Parse(Console.ReadLine());
                    //ask for quantity
                    Console.WriteLine("How many of this product do you have?");
                    //setting Quantity, parse into int
                    catFood.Quantity = int.Parse(Console.ReadLine());
                    //ask for description
                    Console.WriteLine("Add a description for your product");
                    //set description
                    catFood.Description = Console.ReadLine();
                    //ask for weight in pounds of product
                    Console.WriteLine("How many pounds does this product weigh?");
                    //set weight of product in lbs
                    catFood.WeightPounds = int.Parse(Console.ReadLine());
                    //ask if Kitten food
                    Console.WriteLine("Is this product Kitten Food? Type True or False");
                    //set Kitten food to true or false
                    catFood.KittenFood = bool.Parse(Console.ReadLine());
                    //write entered info on console
                    Console.WriteLine(JsonSerializer.Serialize(catFood));
                }
            }
        }
    }

    public class Product
    {
        public string Name {get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
    class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood {  get; set; }
    }
    class DogLeash : Product
    {
        public int LengthInches {  get; set; }
        public string Material {  get; set; }
    }
}
