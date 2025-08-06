using System.Collections.Generic;
using ShopManager.Data.Models;

namespace ShopManager.Data.Repositories
{
    public interface IProductRepository
    {
        int AddProduct(Product product);
        Product GetProductById(int id);
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetByCategory(int categoryId);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
        bool UpdateStockQuantity(int productId, int quantity);
    }
}