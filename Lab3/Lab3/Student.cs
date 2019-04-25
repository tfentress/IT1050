namespace Lab3
{
    class Student
    {

        private string Name;
        private int grade;
        private Instructor teacher;

        public Student(string studentName, Instructor teacherName)
        {
            this.Name = studentName;
            this.teacher = teacherName;
        }

        public string GetName()
        {
            return this.Name;
        }

        public Student()
        {


        }
        public void SetGrade(int studentGrade)
        {
            this.grade = 0;
            this.grade = studentGrade;
        }
        public void PrintNameGradeAndTeacherInfo()
        {
            System.Console.WriteLine("My name is " + " " + this.GetName() + " " + "and I recieved a : " + " " + this.grade);
            System.Console.WriteLine("My teacher" + " " + this.teacher.GetProfessorFullInfo() + " " + "is awesome");
        }
    }

}
