namespace PetStore.Data;
public interface IProductRepository
{
    public ProductEntity CreateProduct(ProductEntity product);
    public List<ProductEntity> GetAllProducts();
    public ProductEntity GetProductByID(int ProductID);
}