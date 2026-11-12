public class Resume
{
    public string _name = "Johnson Johnson";
    public List<Job> _jobList = new List<Job>();

    public void Display()
    {
        Console.WriteLine(_name);
        foreach (Job entry in _jobList)
        {
            entry.Display();
        }
    }
}