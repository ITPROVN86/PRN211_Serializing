using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DemoXmlSerializer
{
    [XmlRoot("Candidate")]
    public class Person
    {
        [XmlElement("FirtName")]
        public string Name { get; set; }
        [XmlElement("RouthAge")]
        public int Age { get; set; }
    }
}
