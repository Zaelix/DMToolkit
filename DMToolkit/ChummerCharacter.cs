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

        [XmlArray("attributes")]
        [XmlArrayItem("attribute")]
        public List<Attribute> attributes;

        public int BOD;
        public int AGI;
        public int REA;
        public int STR;

        public int CHA;
        public int INT;
        public int LOG;
        public int WIL;


        public static ChummerCharacter Load(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlSerializer serializer = new XmlSerializer(typeof(ChummerCharacter));
                XmlSerializer attrSerializer = new XmlSerializer(typeof(Attribute));

                StringReader reader = new StringReader(doc.OuterXml);
                StringReader attReader = new StringReader(doc.OuterXml);

                ChummerCharacter character = serializer.Deserialize(reader) as ChummerCharacter;
                while(attReader.Peek() > 0)
                {
                    character.attributes.Add(attrSerializer.Deserialize(attReader) as Attribute);
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

        public void ParseAttributes()
        {
            foreach (Attribute a in attributes)
            {
                switch (a.name)
                {
                    case "BOD":
                        this.BOD = Convert.ToInt32(a.totalValue);
                        break;
                    case "AGI":
                        this.AGI = Convert.ToInt32(a.totalValue);
                        break;
                    case "REA":
                        this.REA = Convert.ToInt32(a.totalValue);
                        break;
                    case "STR":
                        this.STR = Convert.ToInt32(a.totalValue);
                        break;
                    case "CHA":
                        this.CHA = Convert.ToInt32(a.totalValue);
                        break;
                    case "INT":
                        this.INT = Convert.ToInt32(a.totalValue);
                        break;
                    case "LOG":
                        this.LOG = Convert.ToInt32(a.totalValue);
                        break;
                    case "WIL":
                        this.WIL = Convert.ToInt32(a.totalValue);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
