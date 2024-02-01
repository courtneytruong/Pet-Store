using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Store_class_exercise;
using PetStoreUI;
using PetStoreProducts;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Collections.Generic;
using FluentValidation;
using PetStore.Data;

namespace PetStoreProductLogic;
public class ProductLogic : IProductLogic
{

    private readonly IProductRepository _productRepository;
    private readonly IOrderRepository _orderRepository;

    public ProductLogic(IProductRepository productRepository, IOrderRepository orderRepository)
    {
        _productRepository = productRepository;
        _orderRepository = orderRepository;
    }
    public void AddProduct(ProductEntity product) //add products to dictionary
    {
        _productRepository.CreateProduct(product);
    }
    public List<ProductEntity> GetAllProducts() //retrieves products entered by user
    {
        return _productRepository.GetAllProducts();
    }
    public ProductEntity GetProductByID(int productID)
    {
        return _productRepository.GetProductByID(productID);
    }

    public void AddOrder(OrderEntity order) 
    { 
        _orderRepository.CreateOrder(order);
    }

    public List<OrderEntity> GetAllOrders()
    {
        return _orderRepository.GetAllOrders();
    }

    public OrderEntity GetOrderByID(int orderID)
    {
        return _orderRepository.GetOrderByID(orderID);
    }

}
