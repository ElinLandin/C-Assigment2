namespace WestcoastEducation;

public class Courses(string courseNumber, string courseTitle, string startDate)
{
    public string? CourseNumber { get; set; } = courseNumber;
    public string? CourseTitle { get; set; } = courseTitle;
    public string? CourseLengthWeeks { get; set; }
    public string? CourseLengthDays { get; set; }
    public string? StartDate { get; set; } = startDate;
    public string? EndDate { get; set; }
    
}
