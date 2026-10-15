namespace WestcoastEducation;

public class StudentManager : Student
{
    List<Student> studentList = [];

    public void AddStudent()
    {
        Student students = new();
        studentList.Add(students);
    }


}
