using System.Xml;

namespace DAL
{
    public class ValidationDAL
    {
        public bool ValidateXmlFile(string filePath)
        {
            try
            {
                using (XmlReader reader = XmlReader.Create(filePath))
                {

                    while (reader.Read()) { }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
