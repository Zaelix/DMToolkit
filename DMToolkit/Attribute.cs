using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace DMToolkit
{
    [XmlRoot("character")]
    public class Attribute
    {
        [XmlElement("name")]
        public string name;

        [XmlElement("metatypemin")]
        public string min;

        [XmlElement("metatypemax")]
        public string max;

        [XmlElement("metatypeaugmax")]
        public string augmax;

        [XmlElement("value")]
        public string value;

        [XmlElement("base")]
        public string baseValue;

        [XmlElement("totalvalue")]
        public string totalValue;

        public static Attribute Load(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlSerializer serializer = new XmlSerializer(typeof(ChummerCharacter));

                StringReader reader = new StringReader(doc.OuterXml);
                
                Attribute attr = serializer.Deserialize(reader) as Attribute;
                reader.Close();

                return attr;
            }
            catch (FileNotFoundException e)
            {
                if (e.Source != null)
                    Console.WriteLine("FileNotFoundException source: {0}", e.Source);
                throw;
            };
        }
    }
}
