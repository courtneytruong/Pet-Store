﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Store_class_exercise;
using PetStoreUI;
using PetStoreProducts;



namespace PetStoreProductLogic
{
    public class ProductLogic : IProductLogic
    {
        // creates dictionaries for products
        private List<Product> _products = new List<Product>();
        private Dictionary<string, DogLeash> dogDictionary = new Dictionary<string, DogLeash>();
        private Dictionary<string, CatFood> _catDictionary = new Dictionary<string, CatFood>();

        public ProductLogic()
        {
            _products = new List<Product>();
            _products.Add(new Product { Name = "Friskies", Price = (decimal)10.00, Quantity = 0, Description = "Healthy Weight" });
            _products.Add(new Product { Name = "Royal Canin", Price = (decimal)15.00, Quantity = 5, Description = "Digestive Health" });
            _products.Add(new Product { Name = "Meow Mix", Price = (decimal)8.00, Quantity = 2, Description = "Meaty Bits" });
        }
        public void AddProduct(Product product) //add products to dictionary
        {
            if (product is DogLeash)
            {
                dogDictionary.Add(product.Name, product as DogLeash);
            }
            if (product is CatFood)
            {
                _catDictionary.Add(product.Name, product as CatFood);
            }
            _products.Add(product);

        }
        public List<Product> GetAllProducts() //retrieves products entered by user
        {
            return _products;
        }
        public CatFood GetCatFoodByName(string name) // search for catfood by name
        {
            try
            {
                return _catDictionary[name];
            } 
            catch (Exception)
            {
                return null;
            }
        }

        public List<Product> GetOnlyInStockProducts()
        {
            return _products.InStock();
        }

        public decimal GetTotalPriceOfInventory()
        {
            return GetOnlyInStockProducts().Select(x => x.Price * x.Quantity).Sum();
        }
    }
}
