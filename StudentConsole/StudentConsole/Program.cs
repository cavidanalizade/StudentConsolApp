namespace StudentConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Ceyhun";
            student.Surname = "Agayev";
            student.AvgPoint = 10;

            Student student2 = new Student();
            student2.Name = "Ismayil ";
            student2.Surname = "Ceferov";
            student2.AvgPoint = 10;

            Student student3 = new Student();
            student3.Name = "Cavidan";
            student3.Surname = "Elizade";
            student3.AvgPoint = 10;






            Group group = new Group();
            group.AddStudent(student);
            group.AddStudent(student2);
            group.AddStudent(student3);





            group.FilterByName("c");
            
        }
    }
}