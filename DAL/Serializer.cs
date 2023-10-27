using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.ServiceModel.Syndication;
using Models;

namespace DAL
{
    public class Serializer<T>
    {
        ValidationDAL validation;

        public Serializer()
        {
            validation = new ValidationDAL();
        }

        public void Serialize(List<T> list)
        {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));

                using (FileStream outFile = new FileStream(typeof(T).Name + ".xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, list);
                }
        }

        public List<T> Deserialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            string path = typeof(T).Name + ".xml";
            if (validation.ValidateXmlFile(path) && File.Exists(path)) {
                using (FileStream inFile = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    return (List<T>)xmlSerializer.Deserialize(inFile);
                }
            }
            else
            {
                return new List<T>();
            }
        }

        public async Task<SyndicationFeed> DeserializeRSS(string rss)
        {
            XmlReader reader = XmlReader.Create(rss);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            return feed;
        }
    }
}
