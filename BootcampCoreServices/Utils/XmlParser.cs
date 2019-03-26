using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BootcampCoreServices.Utils
{
    public class XmlParser
    {
        public static T Deserialize<T>(string filePath)
        {
            using (FileStream stream = File.Open(filePath, FileMode.Open))
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));

                return (T)ser.Deserialize(stream);
            }
        }


    }
}
