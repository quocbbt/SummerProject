using masterdata.website.Models;

namespace masterdata.website.Services.Products
{
    public interface IProductsService
    {
        Product GetProduct(int id);
        List<Product> SearchProduct(string keyWord, int categoryId);
        List<Product> GetListProductByListProductId(string listProductId);
        int InsertProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}