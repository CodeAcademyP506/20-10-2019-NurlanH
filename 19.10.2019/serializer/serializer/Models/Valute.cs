using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace serializer.Models
{
    [XmlRoot(ElementName = "Valute")]
    public class Valutes
    {
        public string Nominal { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}