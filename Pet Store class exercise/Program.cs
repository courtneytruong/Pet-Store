using PetStore;
using System;
using System.Text.Json;

namespace PetStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            var productLogic = new ProductLogic();
            //ask to make new product
            Console.WriteLine("Press 1 to add a product or press 2 to look up product");
            Console.WriteLine("Type 'exit' to quit");
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                //confirm whether to make new product
                Console.WriteLine("Press 1 to add a product or press 2 to look up product");
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
                    //add product to list
                    productLogic.AddProduct(catFood);
                    //product added message
                    Console.WriteLine("Product info added " + JsonSerializer.Serialize(catFood));
                }
                if(userInput == "2")
                {
                    //ask for product to search for
                    Console.WriteLine("Type name of product");
                    userInput = Console.ReadLine();
                    //return product asked for
                    Console.WriteLine(JsonSerializer.Serialize(productLogic.GetCatFoodByName(userInput)));
                }
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
    class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }
    }
    class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material { get; set; }
    }

    class ProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> dogDictionary = new Dictionary<string, DogLeash>();
        private Dictionary<string, CatFood> catDictionary = new Dictionary<string, CatFood>();
           
   
        public ProductLogic()
        {
            _products = new List<Product>();
        }
           public void AddProduct(Product product)
            {
                if (product is DogLeash)
                {
                    dogDictionary.Add(product.Name, product as DogLeash);
                }
                if (product is CatFood)
                {              
                    catDictionary.Add(product.Name, product as CatFood);
                }
                _products.Add(product);
            }
            public List<Product> GetAllProducts()
            {
                return _products;
            }
            public CatFood GetCatFoodByName(string name)
            {
                return catDictionary[name];
            }
        }
    }

