namespace WestcoastEducation;

public class StaffManager
{
    List<Employee> employeeList = [];

    public void AddStaff()
    {
        Employee employees = new();
        employeeList.Add(employees);
    }

}
