using System;
using PetStoreProductLogic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Store_class_exercise;
using PetStoreProducts;


namespace PetStoreProductLogic
{
    public interface IProductLogic
    {
        public void AddProduct(Product product); //add products to dictionary

        public List<Product> GetAllProducts(); //retrieves products entered by user

        public CatFood GetCatFoodByName(string name); // search for catfood by name

        public List<Product> GetOnlyInStockProducts(); //returns instock products

        public decimal GetTotalPriceOfInventory();
    }
}


