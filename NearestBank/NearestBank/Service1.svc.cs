using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Web;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace NearestBank
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string[] getNearestBankAtm(string latitude, string longitude, string Type)
        {
            if (string.IsNullOrEmpty(latitude) || string.IsNullOrEmpty(longitude) || string.IsNullOrEmpty(Type))
            {
                string[] output = null;
                return output;
            }
            if (Type.Equals("bank") || Type.Equals("atm") || Type.Equals("bank|atm"))
            {
                string baseUrl = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?";
                string location = "location=" + latitude + "," + longitude;
                string finalUrl = baseUrl + location + "&radius=2500&types=" + Type + "&key=AIzaSyAtGofwEQndI-3ZtvDWg8rOS0aam1XXpUo";

                WebClient webClient = new WebClient();
                string data = webClient.DownloadString(finalUrl);

                JObject json = (JObject)JObject.Parse(data);
                JArray results = (JArray)json.GetValue("results");
                string[] output = new string[results.Count];
                if (results.Count == 0)
                {
                    return null;
                }
                else
                {
                    for (int i = 0; i < results.Count; i++)
                    {
                        JObject place = (JObject)results[i];
                        string name = (string)place.GetValue("name");
                        string address = (string)place.GetValue("vicinity");
                        output[i] += name + "|" + address;
                    }
                    return output;
                }

            }
            else
            {
                string[] output = null;
                return output;
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
