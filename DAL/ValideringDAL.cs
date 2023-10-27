using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public class ValideringDAL
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
                MessageBox.Show("Fel vid validering av XML-filen: " + ex.Message, "Fel!");
                return false;
            }
        }
    }
}
