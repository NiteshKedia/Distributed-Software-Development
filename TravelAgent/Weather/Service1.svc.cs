using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace Weather
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string Weather5day(string location)
        {
            string weather = "";
            string baseurl = "http://api.wunderground.com/api/72f5355630095818/forecast10day/q/";
            baseurl += location;
            baseurl += ".xml";
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(baseurl);
            XmlNode node = doc1.SelectSingleNode("//forecastdays");
            if (node != null)
            {
                XmlNodeList nodes = node.SelectNodes(".//forecastday");

                if (nodes != null)
                {
                    int i = 1;
                    foreach (XmlNode node1 in nodes)
                    {
                        string day = node1["title"].InnerText;
                        string weath = node1["fcttext"].InnerText;
                        weather += day + ":" + weath + "\n";
                        if (i++ == 10)
                            break;
                    }
                }
                else
                    weather = "No data available right now";
            }
            else
                weather = "Please enter a valid Zip code";
            return weather;

        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
