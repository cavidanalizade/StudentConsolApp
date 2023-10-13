class Student
{
    public string Name { get; }
    public string Surname { get; }
    public double AvgPoint { get; }

    public Student(string name, string surname, double avgPoint)
    {
        Name = name;
        Surname = surname;
        AvgPoint = avgPoint;
    }

    public string GetFullName()
    {
        return $"{Name} {Surname}";
    }

    public override string ToString()
    {
        return $"{GetFullName()} (Ortalama : {AvgPoint})";
    }
}