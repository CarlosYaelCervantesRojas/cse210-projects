public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, string negativePoints) : base(name, description, negativePoints)
    {

    }

    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"{typeof(NegativeGoal)}|{_shortName}|{_description}|{_points}";
    }
}