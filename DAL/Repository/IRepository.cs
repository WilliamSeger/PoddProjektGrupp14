using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetByName(string name);
        void Insert(T entity);
        void Update(T entity, int index);
        void Delete(int index);
        void SaveChanges();
        
    }
}
