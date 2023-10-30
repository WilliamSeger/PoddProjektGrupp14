using Models;

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

        public void Delete(int index)
        {
            listOfCategories.RemoveAt(index);
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
