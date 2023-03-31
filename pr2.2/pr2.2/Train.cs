namespace pr2._2;

public class Train
{
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public string DepartureTime { get; set; }
    public Train(string Destination, int TrainNumber, string DepartureTime)
    {
        this.Destination = Destination;
        this.TrainNumber = TrainNumber;
        this.DepartureTime = DepartureTime;
    }
    public Train(){}
    
    public void ListOfTrain(List<Train> train)
    {
        foreach (var element in train)
        {
            Console.Write($"\nНазвание пункта назначения: {element.Destination}, номер поезда: {element.TrainNumber}, время отправления: {element.DepartureTime}");
        }
    }

    public List<Train> InfoAboutTrain(int trainNumber, List<Train> train)
    {
        List<Train> result = new List<Train>();

        var search = train.Where(s => s.TrainNumber == trainNumber);

        if (search != null)
        {
            foreach (var element in search)
            {
                result.Add(new Train(element.Destination, element.TrainNumber, element.DepartureTime));
            }
        }
        else
        {
            Console.WriteLine("Поезд не найден!");
            return null;
        }
        return result;
    }
}