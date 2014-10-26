using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.Web;

namespace TouristAttractions
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
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
