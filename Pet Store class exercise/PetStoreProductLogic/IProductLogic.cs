using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Store_class_exercise;
using PetStoreProducts;
using PetStore.Data;


namespace PetStoreProductLogic;

public interface IProductLogic
{
    public void AddProduct(ProductEntity product); //add products to dictionary

    public List<ProductEntity> GetAllProducts(); //retrieves products entered by user

    public ProductEntity GetProductByID(int productID); // search for catfood by name

}


