using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsole
{
    internal class Group
    {
		private string _no;

		public string No
		{
			get { return _no; }
			set 
			{
				if (NoCheck(value) )
				{
					_no = value;
				}
				 
			}
		}

        public int StudentLimit { get; set; }




        public bool NoCheck(string no)
		{
			no=no.Trim();
			if (char.IsUpper(no[0]) && char.IsUpper(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]) && no.Length<6)
			{
				return true;
			}
			return false;
		}

		Student[] Students=new Student[0];

		public void AddStudent(Student student)
		{

			Array.Resize(ref Students, Students.Length+1);
			Students[Students.Length-1] = student;
		}

		public void FilterByName(string search)
		{
			Student[]searchingStudents= new Student[Students.Length];
			int count = 0;
			foreach(Student student in Students) 
			{
				string username = student.Name.ToLower() + " " + student.Surname.ToLower();
				if (!string.IsNullOrEmpty(username) && username.Contains(search))
				{
					searchingStudents[count]=student;	
					count++;
                    Console.WriteLine(username);
                }

			}
		}

		public void ShowStudents()
		{
			foreach(Student student in Students)
			{
				Console.WriteLine($" {student.Name}  {student.Surname}  {student.AvgPoint} ");
			}
		}


 

    }
}
