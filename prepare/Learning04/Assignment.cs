public class Assignment
{
    private string studentName { get; set; }
    private string topic { get; set; }

    public Assignment()
    {
        studentName ="Jonny";
        topic ="math";
    }

    public string GetSummary()
    {
        string text = $"{studentName} - {topic}";
        return text;
    }
}