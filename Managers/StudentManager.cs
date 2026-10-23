namespace WestcoastEducation;

public class StudentManager
{
    List<Student> studentList = [];

    public void AddStudent(Student student)
    {
        studentList.Add(student);
    }
    //--------------------------------------------------------------------------------
    public void AddExampleStudent()
    {
        Student student001 = new()
        {
            FirstName = "Anna",
            LastName = "Ananasson",
            PersonalIdNumber = "00000000-0000",
            PhoneNumber = "9999-999999",
            Address = "Ananasgatan 9",
            PostalCode = "909 99",
            City = "Skrattmåla"
        };

        Student student002 = new()
        {
            FirstName = "Torsten",
            LastName = "Tvestjärt",
            PersonalIdNumber = "00000000-0000",
            PhoneNumber = "5555-555555",
            Address = "Myrstacksstigen 5",
            PostalCode = "505 55",
            City = "Mögelträsk"
        };

        Student student003 = new()
        {
            FirstName = "Kent-Krister",
            LastName = "Köttsson",
            PersonalIdNumber = "00000000-0000",
            PhoneNumber = "2222-222222",
            Address = "Kotlettvägen 7",
            PostalCode = "207 27",
            City = "Köttsjön"
        };

        AddStudent(student001);
        AddStudent(student002);
        AddStudent(student003);
    }
    //--------------------------------------------------------------------------------
    public void ListStudents()
    {
        Console.WriteLine("Elever:");
        Console.WriteLine("---------------------------------------------");

        foreach (var student in studentList)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine("---------------------------------------------");
    }
}
