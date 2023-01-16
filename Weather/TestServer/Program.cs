using Downloaders.Contollers;
using Downloaders.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestServer
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Введите город: ");
            var city = Console.ReadLine();

            Console.Write("Введите страну: ");
            var country = Console.ReadLine();



            Console.WriteLine("Введите '1', чтобы получить текущую погоду" +
                "\nВведите '2', чтобы получить дневной прогноз погоды" +
                "\nВведите '3', чтобы получить часовой прогноз погоды");

            var choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                    var provider = new CurrentWeatherProvider();
                    var result = await provider.GetWeather(city, country);
                    result.ForEach(s => Print(s));
                    break;

                case "2":
                    var provider1 = new ForecastDailyWeatherProvider();
                    var result1 = await provider1.GetWeather(city, country);
                    result1.ForEach(s => Print(s));
                    break;

                case "3":
                    var provider2 = new ForecastHourlyWeatherProvider();
                    var result2 = await provider2.GetWeather(city, country);
                    result2.ForEach(s => Print(s));
                    break;

                default:
                    break;
            }
        }

        private static void Print(object obj)
        {
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(obj);
                Console.WriteLine("{0}={1}", name, value);
            }
            Console.WriteLine();
        }
    }
}
