using DMToolkit.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DMToolkit
{
    [Serializable, XmlRoot("character")]
    public class ChummerCharacter
    {

        

        [XmlElement("alias")]
        public string alias;

        [XmlElement("primaryarm")]
        public string primaryarm;

        [XmlArray("character")]
        [XmlArrayItem("attribute")]
        //[XmlElement("attribute")]
        public List<Attribute> attributes;
        //public Attribute[] attributes;

        //[XmlAttribute("attributes")]
        //public Object attributes;

        public static ChummerCharacter Load(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlSerializer serializer = new XmlSerializer(typeof(ChummerCharacter));

                StringReader reader = new StringReader(doc.OuterXml);
                StringReader attReader = new StringReader(doc.OuterXml);

                ChummerCharacter character = serializer.Deserialize(reader) as ChummerCharacter;
                while(attReader.Peek() > 0)
                {
                    character.attributes.Add(serializer.Deserialize(attReader) as Attribute);
                }
                reader.Close();
                attReader.Close();

                return character;
            }
            catch (FileNotFoundException e){
                if (e.Source != null)
                    Console.WriteLine("FileNotFoundException source: {0}", e.Source);
                throw;
            };
        }
    }
}
