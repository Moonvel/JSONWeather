using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace JSONWeather
{
    public class GET_JSONdata
    {
        
       public static RootObject Data(string API, string City)
        {
            using (var webClient = new WebClient())
            {
                var json = webClient.DownloadString(string.Format("http://api.openweathermap.org/data/2.5/weather?appid={0}&q={1}", API, City));

                RootObject jSON = JsonConvert.DeserializeObject<RootObject>(json);

                
                return jSON;

                



            }
        }

            
    }
}
