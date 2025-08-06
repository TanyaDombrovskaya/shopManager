using ShopManager.Data.Models;
using ShopManager.Data.Repositories;
using System.Collections.Generic;

namespace ShopManager.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void AddCategory(Category category)
        {
            _categoryRepository.Add(category);
        }

        public bool UpdateCategory(Category category)
        {
            return _categoryRepository.Update(category);
        }

        public bool DeleteCategory(int id)
        {
            if (_categoryRepository.HasProducts(id))
            {
                throw new InvalidOperationException("Нельзя удалить категорию с товарами");
            }
            return _categoryRepository.Delete(id);
        }
    }
}