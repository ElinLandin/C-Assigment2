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

}
