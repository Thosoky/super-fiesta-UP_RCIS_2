namespace pr2._2;

public class Students
{
    public string Surname { get; set; }
    public string DateOfBirth { get; set; }
    public int GroupNum { get; set; }
    public int[] Points { get; set; }
    public Students(string Surname, string DateOfBirth, int GroupNum,int[] Points)
    {
        this.Surname = Surname;
        this.DateOfBirth = DateOfBirth;
        this.GroupNum = GroupNum;
        this.Points = Points;
    }
    public Students() {}

    public void ListOfStudens(List<Students> students)
    {
        foreach (var vaStudent in students)
        {
            Console.Write($"\nФамилия: {vaStudent.Surname}, Дата рождения: {vaStudent.DateOfBirth}, Номер группы: {vaStudent.GroupNum}, Оценки: ");
            foreach (var point in vaStudent.Points)
            {
                Console.Write($"{point} ");
            }
        }
    }
    
    public List<Students> SearchStudent(string surname, string dateOfBirth, List<Students> students)
    {
        List<Students> result = new List<Students>();

        var search = students.Where(s => s.Surname == surname).Where(s => s.DateOfBirth == dateOfBirth);

        if (search != null)
        {
            foreach (var st in search)
            {
                result.Add(new Students(st.Surname, st.DateOfBirth, st.GroupNum, st.Points));
            }
        }
        else
        {
            Console.WriteLine("Студент не найден!");
            return null;
        }
   

        return result;
    }
    
    public void ChangeInfoStudent(List<Students> students)
    {
        string surname;
        string date;
        string n;
        string newSurname;
        string newDateOfBirth;
        int newNumGroup;
    
        Console.Write("Введите фамилию студента: ");
        surname = Console.ReadLine()!;
        Console.Write("Введите дату рождения студента: ");
        date = Console.ReadLine()!;

        var search = SearchStudent(surname, date, students);
        if (search.Count() != 0)
        {
            Console.WriteLine("Что вы хотите изменить?\n 1. Фамилию\n 2. Дату рождения\n 3. Номер группы");
            n = Console.ReadLine()!;

            if (n == "1")
            {
                Console.WriteLine("Введите новую фамилию: ");
                newSurname = Console.ReadLine()!;

                foreach (var st in search)
                {
                    st.Surname = newSurname;
                }
            }
            else if (n == "2")
            {
                Console.WriteLine("Введите новую дату рождения: ");
                newDateOfBirth = Console.ReadLine()!;

                foreach (var st in search)
                {
                    st.DateOfBirth = newDateOfBirth;
                }
            }
            else
            {
                Console.WriteLine("Введите новый номер группы: ");
                newNumGroup = int.Parse(Console.ReadLine()!);

                foreach (var st in search)
                {
                    st.GroupNum = newNumGroup;
                }
            }
            foreach (var st in search)
            {
                Console.Write($"\nФамилия: {st.Surname}, Дата рождения: {st.DateOfBirth}, Номер группы: {st.GroupNum}, Оценки: ");
                foreach (var point in st.Points)
                {
                    Console.Write($"{point} ");
                }
            }
        }
        else
        {
            Console.WriteLine("Студент не найден!");
        }

    }
}