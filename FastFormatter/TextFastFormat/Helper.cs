using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TextFastFormat
{
    public class Helper
    {
        public static void SaveXml<T>(string filename, T product)
        {
            try
            {
                using (var writer = new StreamWriter(filename))
                {
                    var xs = new XmlSerializer(typeof(T));
                    xs.Serialize(writer, product);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            //File.WriteAllText(filename, this.Serialize());
        }

        public static T ReadXml<T>(string filename)
        {
            try
            {
                string content = File.ReadAllText(filename);
                using (var reader = new StringReader(content))
                {
                    var xs = new XmlSerializer(typeof(T));
                    var container = (T)xs.Deserialize(reader);
                    return container;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
