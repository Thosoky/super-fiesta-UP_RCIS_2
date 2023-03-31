using System;

namespace pr2._5
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                DatabaseRequests.GetTypeCarQuery();
                Console.WriteLine();
                Console.Write("Введите вид транспорта: ");
                var carQuery = Console.ReadLine();

                DatabaseRequests.AddTypeCarQuery(carQuery);

                DatabaseRequests.GetTypeCarQuery();
                Console.WriteLine();
                Console.Write("Введите имя водителя: ");
                var firstName = Console.ReadLine();
                Console.Write("Введите фамилию водителя: ");
                var lastName = Console.ReadLine();
                Console.Write("Введите дату рождения водителя (дд.мм.гггг): ");
                var bith = Convert.ToDateTime(Console.ReadLine());

                DatabaseRequests.AddDriverQuery(firstName, lastName, bith);

                DatabaseRequests.GetDriverQuery();
                Console.WriteLine();
                Console.Write("Введите название категории: ");
                var rights = Console.ReadLine();

                DatabaseRequests.AddRightsCategoryQuery(rights);

                Console.Write("Кому добавить права? (введите номер водителя): ");
                int driverNum = int.Parse(Console.ReadLine()!);
                Console.Write("Введите номер категории прав: ");
                DatabaseRequests.GetRightsCategoryQuery();

                Console.Write("Введите: ");
                int rigthsNum = int.Parse(Console.ReadLine()!);

                DatabaseRequests.AddDriverRightsCategoryQuery(driverNum, rigthsNum);

                DatabaseRequests.GetDriverRightsCategoryQuery(driverNum);
                Console.WriteLine();
                Console.WriteLine("Автомобили: ");

                DatabaseRequests.GetCar();

                Console.Write("Введите название автомобиля: ");
                var nameCar = Console.ReadLine();
                Console.Write("Введите номер автомобиля: ");
                var numbCar = Console.ReadLine();
                Console.Write("Введите количество мест в автомобиле: ");
                var numbPassenger = int.Parse(Console.ReadLine()!);
                Console.Write("Введите номер типа автомобиля: ");
                var idTypeCar = int.Parse(Console.ReadLine()!);

                DatabaseRequests.AddCar(nameCar, numbCar, numbPassenger, idTypeCar);

                Console.WriteLine("Автомобили:");

                DatabaseRequests.GetCar();

                DatabaseRequests.GetItinerary();

                Console.WriteLine();
                Console.Write("Введите название маршрута: ");
                var nameItinerary = Console.ReadLine();

                DatabaseRequests.AddItinerary(nameItinerary);
                DatabaseRequests.GetItinerary();

                DatabaseRequests.GetRoute(1);

                Console.Write("Введите ID водителя: ");
                int idDriver = int.Parse(Console.ReadLine()!);
                Console.Write("Введите ID машины: ");
                int idCar = int.Parse(Console.ReadLine()!);
                Console.Write("Введите ID маршрута: ");
                int idItinerary = int.Parse(Console.ReadLine()!);
                Console.Write("Введите количество пассажиров: ");
                int numberPassengers = int.Parse(Console.ReadLine()!);

                DatabaseRequests.AddRoute(idDriver, idCar, idItinerary, numberPassengers);
            }
            catch
            {
                Console.WriteLine("Возникла ошибка!");
            }
        }
    }
}