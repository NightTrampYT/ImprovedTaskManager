namespace ImprovedTaskList;

public class Task
{
    public bool IsDone
    {
        get;
        set;
    }

    public string Description
    {
        get;
        set;
    }

    public Task(string description)
    {
        this.Description = description;
        this.IsDone = false;
    }
}