using ShopManager.Data.Models;
using ShopManager.Data.Repositories;
using System.Collections.Generic;

namespace ShopManager.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
            return _productRepository.GetByCategory(categoryId);
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public int AddProduct(Product product)
        {
            return _productRepository.AddProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return _productRepository.DeleteProduct(id);
        }

        public bool UpdateStock(int productId, int quantityChange)
        {
            return _productRepository.UpdateStockQuantity(productId, quantityChange);
        }
    }
}