using Moq;
using PetStore.Data;
using PetStoreProductLogic;
using PetStoreProducts;
using Pet_Store_class_exercise;
using System.Security.Cryptography.X509Certificates;

namespace PetStore.Tests;

[TestClass]
public class ProductLogicTests
{
    private readonly Mock<IProductRepository> _productRepositoryMock;
    private readonly Mock<IOrderRepository> _orderRepositoryMock;

    private readonly ProductLogic _productLogic;

    public ProductLogicTests()
    {
        _productRepositoryMock = new Mock<IProductRepository>();
        _orderRepositoryMock = new Mock<IOrderRepository>();

        _productLogic = new ProductLogic(_productRepositoryMock.Object, _orderRepositoryMock.Object);

    }

    [TestMethod]
    public void GetProductByID_CallsRepo()
    {
        // Arrange 
        _productRepositoryMock.Setup(x => x.GetProductByID(10))
        .Returns(new ProductEntity { ProductId = 10, Name = "test product" });

        // Act 
        _productLogic.GetProductByID(10);
        // Assert
        _productRepositoryMock.Verify(x => x.GetProductByID(10), Times.Once);
    }
}

