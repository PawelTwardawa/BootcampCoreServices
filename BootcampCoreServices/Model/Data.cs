using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BootcampCoreServices.Model
{
    [Serializable, XmlRoot("requests")]
    public class Data
    {
        [XmlElement("request")]
        public List<Request> Requests { get; set; }
    }
}
