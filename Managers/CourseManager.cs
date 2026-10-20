namespace WestcoastEducation;

public class CourseManager
{
    List<Courses> courseList = [];
    public void AddCourse()
    {

        Courses csharpCourse = new()
        {   
            CourseNumber = "CS101",
            CourseTitle = "c# grundkurs",
            CourseLengthWeeks = "8",
            StartDate = "2027-01-25",
            EndDate = "2027-03-22"
        };
        Courses psychologyCourse = new()
        {
            CourseNumber = "PSY101",
            CourseTitle = "Psykologi A",
            CourseLengthWeeks = "10",
            StartDate = "2027-08-23",
            EndDate = "2027-11-01"
        };
        Courses vegetableCourse = new()
        {
            CourseNumber = "VEG101",
            CourseTitle = "Grönsaker 101",
            CourseLengthDays = "3",
            StartDate = "2027-05-10",
            EndDate = "2027-05-12"
        };

        courseList.AddRange ([csharpCourse, psychologyCourse, vegetableCourse]);


        Console.WriteLine("Kurser:");
        Console.WriteLine("---------------------------------------------");

        foreach (var course in courseList)
        {
            Console.WriteLine(course);
        }
        Console.WriteLine("---------------------------------------------");
    }
}
