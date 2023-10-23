using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        Serializer<Category> dataManager;
        List<Category> listOfCategories;

        public CategoryRepository()
        {
            dataManager = new Serializer<Category>();
            listOfCategories = new List<Category>();
            listOfCategories = GetAll();
        }

        public void Insert(Category entity)
        {
            listOfCategories.Add(entity);
            SaveChanges();
        }

        public void Delete(Category category)
        {
            listOfCategories.RemoveAt(listOfCategories.IndexOf(category));
            SaveChanges();
        }

        public List<Category> GetAll()
        {
            return dataManager.Deserialize();
        }

        public void SaveChanges()
        {
            dataManager.Serialize(listOfCategories);
        }

        public void Update(Category entity, int index)
        {
            if (index >= 0)
            {
                listOfCategories[index] = entity;
            }
            SaveChanges();
        }

        public Category GetByName(string name)
        {
            Category category = null;
            foreach (var item in dataManager.Deserialize())
            {
                if (item.Name.Equals(name))
                {
                    category = item;
                }
            }
            return category;

        }
    }
}
