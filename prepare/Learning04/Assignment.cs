class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        SetStudentName(name);
        SetTopic(topic);
    }
    public void SetStudentName(string name){_studentName = name;}
    public void SetTopic(string topic){_topic = topic;}
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}