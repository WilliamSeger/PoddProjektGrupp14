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
        private string FileName;
        string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath;
        public void Serialize(List<T> list)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));

                using (FileStream outFile = new FileStream((typeof(T).Name) + ".xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, list);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<T> Deserialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));

            using (FileStream inFile = new FileStream((typeof(T).Name + ".xml"), FileMode.Open, FileAccess.Read))
            {
                return (List<T>)xmlSerializer.Deserialize(inFile);
            }
        }
    }
}
