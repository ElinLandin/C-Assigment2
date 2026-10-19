

namespace WestcoastEducation;

public class Program
{

    static void Main()
    {
        CourseManager courseManager = new();
        courseManager.AddCourse();

        Student students = new();
        students.AddStudent();
    }

}