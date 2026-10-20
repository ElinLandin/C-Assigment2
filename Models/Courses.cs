namespace WestcoastEducation;

public class Courses
{
    public required string? CourseNumber { get; set; }
    public required string? CourseTitle { get; set; }
    public string? CourseLengthWeeks { get; set; }
    public string? CourseLengthDays { get; set; }
    public required string? StartDate { get; set; }
    public string? EndDate { get; set; }

    public bool IsItOnline {get; set;}


    public override string ToString()
    {

        string courseFormat = "Klassrum";

        if (IsItOnline)
        {
            courseFormat = "Distans";
        }

        return  $"Kursnummer: {CourseNumber}, Kurstitel: {CourseTitle}, Veckor: {CourseLengthWeeks}" +
                $"Dagar: {CourseLengthDays}, Startdatum: {StartDate} Slutdatum: {EndDate} Kursform: {courseFormat}";
    }
    
}
