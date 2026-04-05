public class ChecklistGoal : Goal
{
    private int _target;
    private int _completed;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus, int completed = 0)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _completed = completed;
    }

    public override int RecordEvent()
    {
        _completed++;

        if (_completed == _target)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        return _completed >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_name} ({_completed}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_target},{_bonus},{_completed}";
    }
}