using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONWeather
{
    public class Program
    {
        static void Main()
        {
            var JSONdata = GET_JSONdata.Data("6ff93bf8e8d4c916ca907ae6def4c864", "Bryansk");

            Console.WriteLine();
        }
    }
}
