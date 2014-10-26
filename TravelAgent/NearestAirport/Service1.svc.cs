using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace NearestAirport
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string GetNearestAirport(string latitude,string longitude)
        {
            string result = "";
            string baseurl = "http://airports.pidgets.com/v1/airports?near=";
            baseurl = baseurl + latitude +","+ longitude + "&n=1";
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(baseurl);
            try
            {
                XmlNode node = doc1.SelectSingleNode("//airport");
                result = node["name"].InnerText;
                result = result + "|" + node["city"].InnerText;
                result = result + "|" + node["state"].InnerText;
                result = result + "|" + node["country"].InnerText;
                return result;
            }
            catch(Exception e)
            {
                return "Error";
            }
            
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
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
