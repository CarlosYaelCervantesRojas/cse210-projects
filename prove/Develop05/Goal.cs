public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }
    public string GetPoints()
    {
        return _points;
    }

    public virtual int GetBonus()
    {
        return 0;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        bool isComplete = IsComplete();
        string shape = isComplete == true ? "X" : " ";
        return $"[{shape}] {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
}