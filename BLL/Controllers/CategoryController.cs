using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Controllers
{
    public class CategoryController
    {
        IRepository<Category> categoryRepository;

        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }

        public void CreateCategory(string name)
        {
            Category newCategory = new Category(name);
            categoryRepository.Insert(newCategory);
        }

        public List<Category> GetCategories()
        {
            return categoryRepository.GetAll();
        }

        public void DeleteCategory(int index)
        {
            categoryRepository.Delete(index);
        }

        public void UpdateCategoryName(int index, string newName)
        {
            Category category = new Category(newName);
            categoryRepository.Update(category, index);
        }
    }
}
