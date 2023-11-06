using PetStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pet_Store_class_exercise
{
    public class ProductLogic
    {
        /// creates dictionaries for products
        private List<Product> _products;
        private Dictionary<string, DogLeash> dogDictionary = new Dictionary<string, DogLeash>();
        private Dictionary<string, CatFood> catDictionary = new Dictionary<string, CatFood>();

        public ProductLogic()
        {
            _products = new List<Product>();
        }
        public void AddProduct(Product product) ///add products to dictionary
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
        public List<Product> GetAllProducts() ///retrieves products entered by user
        {
            return _products;
        }
        public CatFood GetCatFoodByName(string name) /// search for catfood by name
        {
            try
            {
                return catDictionary[name];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
