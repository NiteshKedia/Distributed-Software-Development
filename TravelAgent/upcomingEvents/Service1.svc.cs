using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Json;
using System.Web;

namespace upcomingEvents
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string[] getUpcomingEvents(string latitude, string longitude)
        {
            
            string baseurl = "http://holdmyticket.com/api/public/events/upcoming/";
            string param = "lat/" + latitude + "/lng/" + longitude + "/accuracy/10/apikey/f067165d66b160c69a166395da0cae78";
            string finalurl = baseurl + param;
            WebClient wc = new WebClient();
            try
            {
                string data = wc.DownloadString(finalurl);
                JObject json = (JObject)JObject.Parse(data);
                JArray result = (JArray)json.GetValue("events");
                if (result.Count == 0)
                {
                    string[] results = null;
                    return results;
                }
                else
                {
                    string[] results = new string[result.Count];
                    for (int i = 0; i < result.Count; i++)
                    {
                        JObject res = (JObject)result[i];
                        string title = (string)res.GetValue("title");
                        string start = (string)res.GetValue("start");
                        string end = (string)res.GetValue("end");
                        string address = (string)res.GetValue("venue_address1");
                        address += ", " + (string)res.GetValue("venue_address2");
                        address += ", " + (string)res.GetValue("venue_city");
                        address += ", " + (string)res.GetValue("venue_state");
                        string distance = (string)res.GetValue("distance");

                        results[i] = title + "|" + start + "|" + end + "|" + address + "|" + distance;
                    }
                    return results;

                }
            }
            catch (Exception e)
            {
                return null;
            }
            
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
