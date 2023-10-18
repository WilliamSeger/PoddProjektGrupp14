using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAL
{
    internal class Serializer<T>
    {
        public Serializer() { }

        public void Serialize(string filepath, List<T> dataList)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using (FileStream xmlStream = new FileStream(filepath, FileMode.Create, FileAccess.Write)) 
            {
                xmlSerializer.Serialize(xmlStream, dataList);
            }
        }
    }
}
