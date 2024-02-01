using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;
using Pet_Store_class_exercise;
using PetStoreProducts;

namespace PetStoreUI;

public class MenuLogic : IMenuLogic
{
    public static void WriteStartMenu()
    {
        Console.WriteLine("Welcome! To continue type the number that corresponds with the menu item of your choice:");
        Console.WriteLine("1. Add Product");
        Console.WriteLine("2. Search for Product by ID");
        Console.WriteLine("3. Create Order");
        Console.WriteLine("4. View an Order");
        Console.WriteLine("Type 'exit' to quit");
    }

    public static void WriteConfirmMenu()
    {
        Console.WriteLine("Confirm your choice from the menu below:");
        Console.WriteLine("1. Add Product");
        Console.WriteLine("2. Search for Product by ID");
        Console.WriteLine("3. Create Order");
        Console.WriteLine("4. View an Order");
        Console.WriteLine("Type 'exit' to quit");
    }

    //public static void ConfirmProductType()
    //{
    //Console.WriteLine("What type of Product would you like to add? ");
    //Console.WriteLine("1. Wet Catfood");
    //Console.WriteLine("2. Dry Catfood");
    //}

}
