
namespace Lab3
{
    class Instructor
    {

        private string firstName;
        private string lastName;
        private string Name;
        private string CourseName;
                     
        public Instructor (string teacherfirstName, string teacherlastName, string teacherCourseName)
        {
            this.firstName = teacherfirstName;
            this.lastName = teacherlastName;
            this.CourseName = teacherCourseName;
        
        }

        public void SetStudentGrade(Student studentName, int studentGrade)
        {
           studentName.SetGrade(studentGrade);
        }
        public string GetProfessorFullInfo()

        {
            return this.firstName + " " + this.lastName + "." + this.CourseName;

        }
        public string GetProfessorFullName()

        {
            return this.firstName + " " + this.lastName;

        }

        public void PrintNameAndCourseName()
        {
            System.Console.WriteLine("My name is " + this.GetProfessorFullName() + ".");
            System.Console.WriteLine("I teach  " + this.CourseName);
        }
    }

}
