using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace TouristicXParser
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Validate())
            {
                Console.WriteLine("Document is valid");
                TouristVoucher voucher = null;
                string path = "touristic.xml";

                XmlSerializer serializer = new XmlSerializer(typeof(TouristVoucher));

                StreamReader reader = new StreamReader(path);
                voucher = (TouristVoucher)serializer.Deserialize(reader);
                reader.Close();

                var json = new JavaScriptSerializer().Serialize(voucher);
                Console.WriteLine(json);
            }
            else
            {
                Console.WriteLine("Document is invalid!");
            }
            Console.ReadKey();
        }

        public static bool Validate()
        {

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("http://tempuri.org/touristic.xsd", "touristic.xsd");

            XDocument doc = XDocument.Load("touristic.xml");
            string msg = "";
            doc.Validate(schemas, (o, e) => {
                msg += e.Message + Environment.NewLine;
            });
            return msg.Equals("");

        }
        
    }
}
