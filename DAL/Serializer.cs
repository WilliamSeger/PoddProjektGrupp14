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

            try
            {
                using (FileStream inFile = new FileStream((typeof(T).Name + ".xml"), FileMode.Open, FileAccess.Read))
                {
                    return (List<T>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch(Exception ex)
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
