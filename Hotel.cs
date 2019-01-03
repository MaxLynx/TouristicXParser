using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TouristicXParser
{
    [Serializable()]
    public class Hotel
    {
        [System.Xml.Serialization.XmlElement("stars")]
        public int Stars { get; set; }

        [System.Xml.Serialization.XmlElement("food-incl")]
        public string FoodType { get; set; }

        [System.Xml.Serialization.XmlElement("room-type")]
        public string RoomType { get; set; }

        [XmlArray("additional")]
        [XmlArrayItem("room-incl", typeof(String))]
        public String[] RoomServices { get; set; }
    }
}
