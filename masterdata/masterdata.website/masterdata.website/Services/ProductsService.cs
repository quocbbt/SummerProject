using masterdata.website.Models;
using masterdata.website.Data;
using masterdata.website.Services.Products;

namespace masterdata.website.Services.Products
{
    public class ProductsService : IProductsService
    {
        private readonly MasterDataDbContext _newCoreDbContext;

        public ProductsService(MasterDataDbContext newCoreDbContext)
        {
            _newCoreDbContext = newCoreDbContext;
        }

        public List<Product> SearchProduct(string keyWord, int categoryId)
        {
            List<Product>? listProducts = _newCoreDbContext.Products.Where(x =>
            (string.IsNullOrEmpty(keyWord) || x.Name.Contains(keyWord) || x.Id.ToString().Contains(keyWord)) &&
            (categoryId <= 0 || x.CategoryId == categoryId))?.ToList();
            return listProducts;
        }

        public List<Product> GetListProductByListProductId(string listProductId)
        {
            List<Product>? listProducts = new List<Product>();
            if (!string.IsNullOrEmpty(listProductId))
            {
                var arrProductId = listProductId.Split(',');
                if (arrProductId != null && arrProductId.Any())
                {
                    foreach (var productId in arrProductId)
                    {
                        Int32.TryParse(productId, out int id);
                        if (id > 0)
                        {
                            var product = GetProduct(id);
                            if (product != null)
                            {
                                listProducts.Add(product);
                            }
                        }
                    }
                }
            }
            return listProducts;
        }

        public Product GetProduct(int id)
        {
            var product = _newCoreDbContext.Products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public int InsertProduct(Product product)
        {
            _newCoreDbContext.Products.Add(product);
            _newCoreDbContext.SaveChanges();
            return product.Id;
        }

        public bool UpdateProduct(Product product)
        {
            bool productExist = _newCoreDbContext.Products.Any(x => x.Id == product.Id);
            if (productExist)
            {
                _newCoreDbContext.Products.Update(product);
                _newCoreDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteProduct(int id)
        {
            Product product = _newCoreDbContext.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                _newCoreDbContext.Products.Remove(product);
                _newCoreDbContext.SaveChanges();
                return true;
            }
            return false;
        }

    }
}