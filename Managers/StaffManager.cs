namespace WestcoastEducation;

public class StaffManager
{
    List<Employee> employeeList = [];

    public void AddTeacher(Teacher teacher)
    {
        employeeList.Add(teacher);
    }

    public void AddSupervisor(Supervisor supervisor)
    {
        employeeList.Add(supervisor);
    }

    public void AddAdministrator(Administrator administrator)
    {
        employeeList.Add(administrator);
    }
//-----------------------------------------------------------------------
    public void AddExampleStaff()
    {
        Teacher teacher = new()
        {
          FirstName = "Börje",
          LastName = "Buggström",
          PersonalIdNumber = "00000000-0000",
          PhoneNumber = "8888-888888",
          Address = "Felsökeby 101",
          PostalCode = "123 45",
          City = "Debuggbyn",
          AreaOfExpertise = "C#, Systemutveckling",
        };
        Supervisor supervisor = new()
        {
          FirstName = "Kajsa",
          LastName = "Kaoskvist",
          PersonalIdNumber = "00000000-0000",
          PhoneNumber = "4444-444444",
          Address = "Panikparken 7",
          PostalCode = "123 45",
          City = "Hysterihult",
          AreaOfExpertise = "Projektledning, IT",
          HireDate = new DateTime(1988, 4, 1)
        };
        Administrator administrator = new()
        {
          FirstName = "Barbro",
          LastName = "Blankett",
          PersonalIdNumber = "00000000-0000",
          PhoneNumber = "7777-777777",
          Address = "Arkivvägen 12",
          PostalCode = "123 45",
          City = "Paragrafköping",
          AreaOfExpertise = "Administration, Pappersvändning",
          HireDate = new DateTime(2000, 1, 10)
        };

        AddTeacher(teacher);
        AddSupervisor(supervisor);
        AddAdministrator(administrator);
    }
//---------------------------------------------------------------------------
    public void ListEmployees()
    {
        Console.WriteLine("Personal:");
        Console.WriteLine("---------------------------------------------");

        foreach (var employee in employeeList)
        {
            Console.WriteLine(employee);
        }
        Console.WriteLine("---------------------------------------------");
}
    }
    
