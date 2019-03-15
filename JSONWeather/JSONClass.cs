using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace JSONWeather
{

    [DataContract]
    public class Coord
    {
        [DataMember]
        public double Lon { get; set; }
        [DataMember]
        public double Lat { get; set; }
    }

    [DataContract]
    public class Weather
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Main { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Icon { get; set; }
    }

    [DataContract]
    public class Main
    {
        [DataMember]
        public double Temp { get; set; }
        [DataMember]
        public int Pressure { get; set; }
        [DataMember]
        public int Humidity { get; set; }
        [DataMember]
        public double Temp_min { get; set; }
        [DataMember]
        public double Temp_max { get; set; }
    }

    [DataContract]
    public class Wind
    {
        [DataMember]
        public int Speed { get; set; }
        [DataMember]
        public int Deg { get; set; }
    }

    [DataContract]
    public class Clouds
    {
        [DataMember]
        public int All { get; set; }
    }

    [DataContract]
    public class Sys
    {
        [DataMember]
        public int Type { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public double Message { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public int Sunrise { get; set; }
        [DataMember]
        public int Sunset { get; set; }
    }

    [DataContract]
    public class RootObject
    {
        [DataMember]
        public Coord Coord { get; set; }
        [DataMember]
        public List<Weather> Weather { get; set; }
        [DataMember]
        public string @Base { get; set; }
        [DataMember]
        public Main Main { get; set; }
        [DataMember]
        public int Visibility { get; set; }
        [DataMember]
        public Wind Wind { get; set; }
        [DataMember]
        public Clouds Clouds { get; set; }
        [DataMember]
        public int Dt { get; set; }
        [DataMember]
        public Sys Sys { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Cod { get; set; }
    }
}
