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
            string city = string.Empty;

            Console.WriteLine("Введите город: ");
            city = Console.ReadLine();

            try
            {  
            var JSONdata = GET_JSONdata.Data("6ff93bf8e8d4c916ca907ae6def4c864", city);
            Console.WriteLine("Тест: ");
            Console.WriteLine($"{JSONdata.Weather[0].Main}\nДавление: {JSONdata.Main.Pressure}\tВлажность: {JSONdata.Main.Humidity}" +
                $"\nТемпература: {JSONdata.Main.Temp}");
            Console.WriteLine("JSON в *.txt: ");
            Serialization.CreateJSONFile(JSONdata);
            }
            catch (System.Net.WebException ex)
            {
                Console.WriteLine(ex.Message + "\nВведите название города без ошибок." );
            }





            Console.ReadKey();





        }
    }
}
