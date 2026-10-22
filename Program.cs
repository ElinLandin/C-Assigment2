

namespace WestcoastEducation;

public class Program
{

    static void Main()
    {
        CourseManager courseManager = new();
        courseManager.AddExampleCourse();
        courseManager.ListCourses();

        StudentManager studentManager = new();
        studentManager.AddExampleStudent();
        studentManager.ListStudents();

        StaffManager staffManager = new();
        staffManager.AddExampleStaff(courseManager);
        staffManager.ListEmployees();
    }   

}