namespace PetStore.Data;

public class ProductRepository : IProductRepository
{
    private readonly ProductContext _context;

    public ProductRepository(ProductContext context)
    {
        _context = context;
    }

    public List<ProductEntity> GetAllProducts()
    {
        var productList = _context.Products.ToList();
        return productList;
    }
    public ProductEntity CreateProduct(ProductEntity product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
        return product;
    }

    public ProductEntity GetProductByID(int ProductID)
    {
        var productID = _context.Products.FirstOrDefault(e => e.ProductId == ProductID);
        return productID;
    }
}




