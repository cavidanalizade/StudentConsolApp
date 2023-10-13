using System;

class Program
{
    static void Main(string[] args)
    {
        Group[] groups = new Group[10];
        int groupCount = 0;

        while (true)
        {
            Console.WriteLine("\n====== Menyu ======");
            Console.WriteLine("1. Qrup yarat");
            Console.WriteLine("2. Butun telebeleri goster");
            Console.WriteLine("3. Telebe elave et");
            Console.WriteLine("4. Ad ile telebeleri sec");
            Console.WriteLine("0. cixis");

            Console.Write("Seciminizi daxil edin: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Qrup nomresini daxil edin (2 boyuk herf ve 3 reqem): ");
                    string groupNo = Console.ReadLine();
                    if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) &&groupNo.Length==5)
                    {

                    
                    Console.Write("Telebe limitini daxil edin (5 ile 18 arasında): ");
                    int studentLimit = int.Parse(Console.ReadLine());



                    if (groupCount < 10)
                    {
                        groups[groupCount] = new Group(groupNo, studentLimit);
                        groupCount++;
                        Console.WriteLine($"{groupNo} qrupu limiti {studentLimit} olan qrup yaradildi.");
                    }
                    else
                    {
                        Console.WriteLine("en cox 10 qrup yarada bilersiniz.");
                    }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------");


                        Console.WriteLine("Qrup yanlis adlandirildi");
                    }
                    break;

                case "2":
                    foreach (Group group in groups)
                    {
                        if (group != null)
                        {
                            group.ShowAllStudents();
                        }
                    }
                    break;

                case "3":
                    Console.Write("telebe elave etmek ucun qrup nomresini daxil edin: ");
                    string groupNoToAdd = Console.ReadLine();
                    Group groupToAdd = null;
                    foreach (Group group in groups)
                    {
                        if (group != null && group.No == groupNoToAdd)
                        {
                            groupToAdd = group;
                            break;
                        }
                    }

                    if (groupToAdd != null)
                    {
                        Console.Write("Telebenin adını daxil edin: ");
                        string name = Console.ReadLine();
                        Console.Write("Telebenin soyadını daxil edin: ");
                        string surname = Console.ReadLine();
                        Console.Write("Telebenin ortalama noqtesini daxil edin (0-100): ");
                        double avgPoint = double.Parse(Console.ReadLine());

                        Student student = new Student(name, surname, avgPoint);
                        groupToAdd.AddStudent(student);
                    }
                    else
                    {
                        Console.WriteLine($"{groupNoToAdd} Qrupu movcud deyil.");
                    }
                    break;

                case "4":
                    Console.Write("Ad filtirini daxil edin: ");
                    string nameFilter = Console.ReadLine();
                    foreach (Group group in groups)
                    {
                        if (group != null)
                        {
                            Student[] filteredStudents = group.FilterByName(nameFilter);
                            Console.WriteLine($"{group.No} qrupunda '{nameFilter}'   adlarla telebeler:");
                            foreach (Student student in filteredStudents)
                            {
                                if (student != null)
                                {
                                    Console.WriteLine(student);
                                }
                            }
                        }
                    }
                    break;

                case "0":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Yanlıs secim");
                    break;
            }
        }
    }
}
