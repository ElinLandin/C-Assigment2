using System.Net.Mail;

namespace WestcoastEducation;

public class Supervisor : Employee
{
    public DateTime HireDate { get; set; }
    public override string ToString()
    {
        return base.ToString() + $", Anställningsdatum: {HireDate:yyyy-MM-dd}";
    }
}
