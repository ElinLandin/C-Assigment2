namespace WestcoastEducation;

public class CourseManager : Courses
{
    
    List<Courses> courseList = [];
    public void AddCourse()
    {

        Courses courses = new ();
        courseList.Add(courses);

    }
}
