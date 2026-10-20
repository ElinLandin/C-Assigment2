

namespace WestcoastEducation;

public class Program
{

    static void Main()
    {
        CourseManager courseManager = new();
        courseManager.AddCourse();

        StudentManager studentManager = new();
        studentManager.AddStudent();

        StaffManager staffManager = new();


    }   

}