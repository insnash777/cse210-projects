public class Assignment
{
    private string _studentName = "Samuel Bennet";
    private string _topic = "Multiplication";

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}