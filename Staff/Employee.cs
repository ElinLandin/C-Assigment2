namespace WestcoastEducation;

public class Employee : Person
{
    public string? AreaOfExpertise{ get; set; } 
    public List<Courses> AssignedCourses { get; set; } = [];
    public DateTime HireDate{ get; set; }

    public override string ToString()
    {
        return base.ToString() +
            $", Kunskapsområde: {AreaOfExpertise}, " +
            $"Anställningsdatum: {HireDate:yyy-MM-dd}";
    }
}
