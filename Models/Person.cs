namespace WestcoastEducation;

public class Person(string firstName, string lastName, string personalIdNumber)
{
    
    public string? FirstName{ get; set; } = firstName;
    public string? LastName{ get; set; } = lastName;
    public string? PersonalIdNumber{ get; set; } = personalIdNumber;
    public string? PhoneNumber{ get; set; } 
    public string? Address{ get; set;}
    public string? PostalCode{ get; set;}
    public string? City{ get; set;}


    public override string ToString()
    {
        return  $"Förnamn: {FirstName}, Efternamn: {LastName}, " +
                $"Personnummer: {PersonalIdNumber}, Telefonnummer: {PhoneNumber}, " +
                $"Adress:{Address}, Postkod: {PostalCode}, Stad: {City}";
    }

}
