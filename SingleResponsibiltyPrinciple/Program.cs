#region SRO_Before

//class Employee
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public DateOnly BirthOfDate { get; set; }
//
//    public void PrintTimeSheetReport()
//    {
//        Console.WriteLine($"{Name} {Surname} {BirthOfDate}");
//    }
//}


#endregion

#region SRO_After

class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateOnly BirthOfDate { get; set; }
}

class TimeSheetReport
{

    public void Print(Employee e)
    {
        Console.WriteLine($"{e.Name} {e.Surname} {e.BirthOfDate}");
    }
}


#endregion
