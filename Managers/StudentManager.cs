namespace WestcoastEducation;

public class StudentManager
{
    List<Student> studentList = [];

    public void AddStudent()
    {
        Student student001 = new()
        {
            FirstName = "Anna",
            LastName = "Ananasson",
            PersonalIdNumber = "19990909-9999",
            PhoneNumber = "0909-999999",
            Address = "Ananasgatan 9",
            PostalCode = "909 99",
            City = "Skrattmåla"
        };

        Student student002 = new()
        {
            FirstName = "Torsten",
            LastName = "Tvestjärt",
            PersonalIdNumber = "20050505-5555",
            PhoneNumber = "0505-555555",
            Address = "Myrstacksstigen 5",
            PostalCode = "505 55",
            City = "Mögelträsk"  
        };

        Student student003 = new()
        {
            FirstName = "Kent-Krister",
            LastName = "Köttsson",
            PersonalIdNumber = "19720207-0207",
            PhoneNumber = "0207-002277",
            Address = "Kotlettvägen 7",
            PostalCode = "207 27",
            City = "Köttsjön"
        };

        studentList.AddRange ([student001, student002, student003]);

        Console.WriteLine("Elever:");
        Console.WriteLine("---------------------------------------------");

        foreach (var student in studentList)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine("---------------------------------------------");
    }   
}
