namespace pr2._2;

public class Person
{
    public  string Name { get; }
    public  int Age { get; }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public Person()
    {
        Name = "Elizaveta";
        Age = 18;
    }

    ~Person()
    {
        Console.WriteLine($"{Name} has deleted");
    }
}