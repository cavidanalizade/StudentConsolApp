class Group
{
    public string No { get; }
    public int StudentLimit { get; }
    public Student[] Students;
    private int studentCount;

    public Group(string no, int studentLimit)
    {
        No = no;
        StudentLimit = studentLimit;
        Students = new Student[StudentLimit];
        studentCount = 0;
    }

    public void AddStudent(Student student)
    {
        if (studentCount < StudentLimit)
        {
            Students[studentCount] = student;
            studentCount++;
            Console.WriteLine($"{student.GetFullName()} {No} qrupuna elave edildi.");
        }
        else
        {
            Console.WriteLine("Qrup doludur!!!");
        }
    }

    public Student[] FilterByName(string nameFilter)
    {
        nameFilter = nameFilter.ToLower();
        Student[] filteredStudents = new Student[StudentLimit];
        int count = 0;

        foreach (Student student in Students)
        {
            if (student != null && student.GetFullName().ToLower().Contains(nameFilter))
            {
                filteredStudents[count] = student;
                count++;
            }
        }

        return filteredStudents;
    }

    public void ShowAllStudents()
    {
        Console.WriteLine($"{No} qrupunda olan butun telebeler:");
        foreach (Student student in Students)
        {
            if (student != null)
            {
                Console.WriteLine(student);
            }
        }
    }
}
