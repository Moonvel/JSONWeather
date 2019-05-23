using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace JSONWeather
{
    public class GET_JSONdata
    {
        
       public static RootObject Data(string API, string City)
        {
            WebRequest request = WebRequest.Create(string.Format("http://api.openweathermap.org/data/2.5/weather?appid={0}&q={1}&units=metric", API, City));
            WebResponse response = request.GetResponse();        
            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    string json = reader.ReadToEnd();

                    RootObject JSON = JsonConvert.DeserializeObject<RootObject>(json);

                    return JSON;
                }
            }



            /*  using (var webClient = new WebClient())
            {
                var json = webClient.DownloadString(string.Format("http://api.openweathermap.org/data/2.5/weather?appid={0}&q={1}", API, City));

                RootObject JSON = JsonConvert.DeserializeObject<RootObject>(json);

                
                return JSON; 

            } */
        }


    }
}
