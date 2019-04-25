
namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor john = new Instructor ("John", "Cannon", "English");
            Instructor mike = new Instructor ("Mike", "Wall", "Math");

            Student jane = new Student ("Jane",john);
            Student joe = new Student("Joe",john);
            Student melissa = new Student("Melissa", mike);
            Student matt = new Student("Matt", mike);

            john.SetStudentGrade(jane, 95);
            john.SetStudentGrade(joe, 85);
            mike.SetStudentGrade(melissa, 90);
            mike.SetStudentGrade(matt, 92);

            jane.PrintNameGradeAndTeacherInfo();
            joe.PrintNameGradeAndTeacherInfo();
            melissa.PrintNameGradeAndTeacherInfo();
            matt.PrintNameGradeAndTeacherInfo();

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadLine();
        }
    }
}
