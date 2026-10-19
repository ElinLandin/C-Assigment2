namespace WestcoastEducation;

public class CourseManager
{
    List<Courses> courseList = [];
    public void AddCourse()
    {

        Courses csharpCourse = new("CS101", "c# grundkurs", "2027-01-25")
        {
            CourseLengthWeeks = "8",
            EndDate = "2027-03-22"
        };
        Courses psychologyCourse = new("PSY101", "Psykologi A", "2027-08-23")
        {
            CourseLengthWeeks = "10",
            EndDate = "2027-11-01"
        };
        Courses vegetableCourse = new("VEG101", "Grönsaker 101", "2027-05-10")
        {
            CourseLengthDays = "3",
            EndDate = "2027-05-12"
        };

        courseList.AddRange ([csharpCourse, psychologyCourse, vegetableCourse]);


        Console.WriteLine("Kurser:");
        Console.WriteLine("---------------------------------------------");

        foreach (var course in courseList)
        {
            Console.WriteLine(course);
        }

    }
}
