using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Repository
{
    public class FlowRepository : IRepository<Flow>
    {
        Serializer<Flow> FlowSerializer;
        List<Flow> FlowList;

        public FlowRepository() 
        { 
            FlowList = new List<Flow>();
            FlowSerializer = new Serializer<Flow>();
        }
        
        public List<Flow> GetAll()
        {
            return FlowSerializer.Deserialize();
        }
        
        public Flow GetByName(string name)
        {
            Flow flow = null;
            foreach(var item in FlowSerializer.Deserialize())
            {
                if (item.Name.Equals(name))
                {
                    flow = item;
                }
            }
            return flow;

        }
        public void Insert(Flow flow)
        {
            FlowList.Add(flow);
            SaveChanges();
        }

        public void Update(Flow flow, int index) 
        { 
            if (index >= 0)
            {
                FlowList[index] = flow;
            }
            SaveChanges();
        }
        
        public void Delete(int index)
        {
            FlowList.RemoveAt(index);
            SaveChanges();
        }

        public void SaveChanges()
        {
            FlowSerializer.Serialize(FlowList);
        }
    }
}
