using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace serializer.Models
{
    [XmlRoot(ElementName = "ValueType")]
    public class ValueTypes
    {
        public Valute[] Valute { get; set; }
    }
}