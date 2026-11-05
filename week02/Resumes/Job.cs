public class Job
{
    public string _company = "";
    public string _JobTitle = "";

    public double _startYear;

    public double _endYear;

    public void Display ()
    {
        Console.WriteLine($"{_JobTitle}, {_company}, {_startYear}, {_endYear}");
    }
}