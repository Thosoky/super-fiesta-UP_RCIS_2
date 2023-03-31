
namespace pr2._6;
using System.Net;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("\tФункции: \n\t1. Текущая погода. \n\t2. Прогноз на 5 дней\n");
            Console.Write("\n\tФункция: ");
            string ask = Console.ReadLine()!;

            Console.Write("\n\tВведите название города (на латинице): ");
            string city = Console.ReadLine()!;
            switch (ask)
            {
                case "1":
                    string url =
                        $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&lang=ru&appid=855340cdc444bc0d97ac0a397b38ff12";
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

                    HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                    string response;

                    using (StreamReader streamReaderForecast = new StreamReader(httpWebResponse.GetResponseStream()!))
                    {
                        response = streamReaderForecast.ReadToEnd();
                    }

                    RootCurrent? current = JsonConvert.DeserializeObject<RootCurrent>(response);

                    Console.WriteLine(
                        $"\n\tТекущая температура: {current.main.temp}°, Примечание: {current.weather[0].description} \n\tСкорость ветра (м/с): {current.wind.speed}");

                    break;
                case "2":
                    string urlForecast =
                        $"http://api.openweathermap.org/data/2.5/forecast?q={city}&units=metric&lang=ru&appid=855340cdc444bc0d97ac0a397b38ff12";

                    HttpWebRequest httpWebRequestForecast = (HttpWebRequest)WebRequest.Create(urlForecast);

                    HttpWebResponse httpWebResponseForecast = (HttpWebResponse)httpWebRequestForecast.GetResponse();

                    string responseForecast;

                    using (StreamReader streamReaderForecast =
                           new StreamReader(httpWebResponseForecast.GetResponseStream()!))
                    {
                        responseForecast = streamReaderForecast.ReadToEnd();
                    }

                    RootObject? forecast = JsonConvert.DeserializeObject<RootObject>(responseForecast);

                    Console.WriteLine();

                    for (int i = 3; i < 36; i += 8)
                    {
                        Console.WriteLine(
                            $"\tДата: {forecast.list[i].dt_txt}, Температура: {forecast.list[i].main.temp}°\n\tПримечание: {forecast.list[i].weather[0].description}, Скорость ветра (м/c): {forecast.list[i].wind.speed}\n");
                    }

                    break;
                default:
                    Console.WriteLine("Неверный номер функции.");
                    break;
            }
        }
        catch
        {
            Console.WriteLine("\tОшибка.\tВероятно, неправильно введено название города.");
        }
    }
}