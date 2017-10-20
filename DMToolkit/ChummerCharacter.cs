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
    class ChummerCharacter
    {
        [XmlAttribute("alias")]
        public string alias;

        [XmlAttribute("attributes")]
        public Object attributes;

        public static ChummerCharacter Load(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ChummerCharacter));

                StringReader reader = new StringReader(path);

                ChummerCharacter character = serializer.Deserialize(reader) as ChummerCharacter;

                reader.Close();

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
