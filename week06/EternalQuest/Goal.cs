public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string desc, int points)
    {
        _name = name;
        _description = desc;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"[ ] {_name} ({_description})";
    }

    public abstract string GetStringRepresentation();
}