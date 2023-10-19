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
        public Serializer(string fileName) 
        {
            FileName = fileName;
            filePath = directoryPath + "\\" + fileName;

        }

        public void Serialize(List<T> dataList)
        {
            try { 
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                using (FileStream xmlStream = new FileStream(filePath, FileMode.Create, FileAccess.Write)) 
                {
                    xmlSerializer.Serialize(xmlStream, dataList);
                }
            }
            catch(DirectoryNotFoundException e) {
            //    (directoryPath + "not found.", "Directory not found");
            }
            catch(FileNotFoundException e)
            {
             //  MessageBox.Show (filePath + " not found.", "File not found");
            }
        }
        public List<T> Deserialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using (FileStream xmlStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
               return (List<T>)xmlSerializer.Deserialize(xmlStream);
            }
        }
    }
}
