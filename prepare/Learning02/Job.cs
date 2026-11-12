using System.Data.SqlTypes;

public class Job
{
    public string _company;
    public string _jobTilte; //I thought the spelling error was funny. It's _jobTitle.
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTilte} ({_company}) {_startYear}-{_endYear}");
    }
}