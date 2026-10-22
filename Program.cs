

namespace WestcoastEducation;

public class Program
{

    static void Main()
    {
        CourseManager courseManager = new();
        courseManager.AddExampleCourse();

        StudentManager studentManager = new();
        studentManager.AddExampleStudent();

        StaffManager staffManager = new();


    }   

}