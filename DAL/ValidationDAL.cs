using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
