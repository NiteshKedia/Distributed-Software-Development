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

namespace RequiredServices
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

        public string[] getTouristAttraction(string latitude, string longitude)
        {

            string baseurl = "https://api.foursquare.com/v2/venues/explore?client_id=UVUDLYG1NY1SU1HT52FE13H0N3VMOPVKOK52BP4Z1VJ1540K&client_secret=Z3YHCONZOHQ5G3DVGKDOXIQ3CWAVPOU5S2KIQVY54F4FZPQK&v=20141018&limit=10&ll=";
            string location = latitude + "," + longitude;
            string finalURL = baseurl + location + "&section=sights";
            WebClient wc = new WebClient();
            try
            {
                string jsonStr = wc.DownloadString(finalURL);
                dynamic nearestResults = JsonConvert.DeserializeObject(jsonStr);
                Newtonsoft.Json.Linq.JArray itemresults = nearestResults.response.groups[0].items;

                if (itemresults != null)
                {
                    int numResults = itemresults.Count;
                    string[] result = new string[numResults];
                    for (int i = 0; i < numResults; i++)
                    {
                        if (nearestResults.response.groups[0].items[i].venue.name != null)
                        {
                            string name = nearestResults.response.groups[0].items[i].venue.name;
                            string[] names = name.Split('|');
                            name = names[0];
                            result[i] = result[i] + name + "|";
                        }
                        if (nearestResults.response.groups[0].items[i].venue.location.formattedAddress != null)
                        {
                            Newtonsoft.Json.Linq.JArray address = nearestResults.response.groups[0].items[i].venue.location.formattedAddress;
                            int lenaddr = address.Count;
                            string vaddress = "";
                            for (int j = 0; j < lenaddr; j++)
                            {
                                vaddress = vaddress + address[j].ToString() + " ";
                            }
                            result[i] = result[i] + vaddress + "|";
                        }
                        if (nearestResults.response.groups[0].items[i].venue.categories[0].name != null)
                        {
                            string categories = nearestResults.response.groups[0].items[i].venue.categories[0].name;
                            result[i] = result[i] + categories + "|";
                        }
                        if (nearestResults.response.groups[0].items[i].venue.rating != null)
                        {
                            string rating = nearestResults.response.groups[0].items[i].venue.rating;
                            result[i] = result[i] + rating;
                        }

                    }
                    return result;
                }
                else
                {
                    string[] r = new string[1];
                    r[0] = "error";
                    return r;
                }
            }
            catch (Exception e)
            {
                string[] r = new string[1];
                r[0] = "error";
                return r;
            }

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


        public string NewsFocus(string topic)
        {

            string news = "";
            string baseurl = "https://news.google.com/news/feeds?q=";
            baseurl += topic;
            baseurl += "&output=rss";
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(baseurl);
            XmlElement root = doc1.DocumentElement;
            XmlNodeList nodes = doc1.GetElementsByTagName("item");
            foreach (XmlNode node in nodes)
            {
                string tempf = node["title"].InnerText;
                string link = node["link"].InnerText;
                news = news + tempf + "|" + link + "\n";
            }


            //string news = "Ebolaaaa";
            return news;
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
