using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BootcampCoreServices.Model
{
    [Serializable, XmlRoot("request")]
    public class Request
    {
        [Name("Client_Id")]
        [XmlElement("clientId")]
        public string ClientId { get; set; }

        [Name("Request_id")]
        [XmlElement("requestId")]
        public long? RequestId { get; set; }

        [Name("Name")]
        [XmlElement("name")]
        public string Name { get; set; }

        [Name("Quantity")]
        [XmlElement("quantity")]
        public int? Quantity { get; set; }

        [Name("Price")]
        [XmlElement("price")]
        public float? Price { get; set; }
    } 
}
