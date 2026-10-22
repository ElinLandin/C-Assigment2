using System.Security.Cryptography.X509Certificates;

namespace WestcoastEducation;

public class CourseManager
{
    List<Courses> courseList = [];
    public void AddCourse(Courses courses)
    {
        courseList.Add(courses);
    }
//--------------------------------------------------------------------
    public void AddExampleCourse()
    {

        Courses csharpCourse = new()
        {   
            CourseNumber = "CS101",
            CourseTitle = "c# grundkurs",
            StartDate = new DateTime(2027, 1, 25),
            EndDate = new DateTime(2027, 3, 22),
            IsItOnline = true
        };
        Courses psychologyCourse = new()
        {
            CourseNumber = "PSY101",
            CourseTitle = "Psykologi A",
            StartDate = new DateTime(2027, 8, 23),
            EndDate = new DateTime(2027, 11, 1),
            IsItOnline = false
        };
        Courses vegetableCourse = new()
        {
            CourseNumber = "VEG101",
            CourseTitle = "Grönsaker 101",
            StartDate = new DateTime(2027, 5, 10),
            EndDate = new DateTime(2027, 5, 12),
            IsItOnline = false
        };

        AddCourse(csharpCourse);
        AddCourse(psychologyCourse);
        AddCourse(vegetableCourse);
    }
//---------------------------------------------------------------------------
    public void ListCourses()
    {
        Console.WriteLine("Kurser:");
        Console.WriteLine("---------------------------------------------");

        foreach (var course in courseList)
        {
            Console.WriteLine(course);
        }
        Console.WriteLine("---------------------------------------------");
}
    public Courses? GetCourse(string courseNumber)
    {
        foreach (var course in courseList)
        {
            if (course.CourseNumber== courseNumber)
            {
                return course;
            }
        }
        return null;
        
    }

    }

    

