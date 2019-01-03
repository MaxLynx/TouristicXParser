using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TouristicXParser
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("tourist-voucher")]
    public class TouristVoucher
    {
        [System.Xml.Serialization.XmlAttribute("id")]
        public string ID { get; set; }

        [System.Xml.Serialization.XmlElement("type")]
        public string Type { get; set; }

        [System.Xml.Serialization.XmlElement("country")]
        public string Country { get; set; }

        [System.Xml.Serialization.XmlElement("days-number")]
        public int DaysNumber { get; set; }

        [System.Xml.Serialization.XmlElement("nights-number")]
        public int NightsNumber { get; set; }

        [System.Xml.Serialization.XmlElement("transport")]
        public string Transport { get; set; }

        [System.Xml.Serialization.XmlElement("hotel-characteristic")]
        public Hotel Hotel { get; set; }

        [XmlArray("services-incl")]
        [XmlArrayItem("service", typeof(String))]
        public String[] Services { get; set; }

        [System.Xml.Serialization.XmlElement("cost")]
        public double Cost { get; set; }
    }
}
