public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        
    }
    public override bool IsComplete()
    {
        bool isComplete = _amountCompleted == _target ? true : false;
        return isComplete;
    }
    public override string GetDetailsString()
    {
        bool isComplete = IsComplete();
        string shape = isComplete == true ? "X" : " ";
        return $"[{shape}] {_shortName} ({_description}) -- Current completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"{typeof(CheckListGoal)}|{_shortName}|{_description}|{_points}|{_bonus}|{_amountCompleted}|{_target}";
    }
}