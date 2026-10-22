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

    public void AddExampleStaff()
    {
        Teacher teacher = new()
        {
          FirstName = "",
          LastName = "",
          PersonalIdNumber = "",
          PhoneNumber = "",
          Address = "",
          PostalCode = "",
          City = "",
          AreaOfExpertise = "",
        };
        Supervisor supervisor = new()
        {
          FirstName = "",
          LastName = "",
          PersonalIdNumber = "",
          PhoneNumber = "",
          Address = "",
          PostalCode = "",
          City = "",
          AreaOfExpertise = "",
          HireDate = new DateTime()
        };
        Administrator administrator = new()
        {
          FirstName = "",
          LastName = "",
          PersonalIdNumber = "",
          PhoneNumber = "",
          Address = "",
          PostalCode = "",
          City = "",
          AreaOfExpertise = "",
          HireDate = new DateTime()
        };

        AddExampleStaff();
        AddExampleStaff();
        AddExampleStaff();
    }

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
    
