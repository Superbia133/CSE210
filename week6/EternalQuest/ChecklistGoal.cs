public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonus;
    
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int timesCompleted = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
    }

    public override void RecordEvent(ref int score)
    {
        if (_timesCompleted < _targetCount)
        {
            _timesCompleted++;
            score += _points;
            Console.WriteLine($"Progress recorded! You earned {_points} points.");

            if (_timesCompleted == _targetCount)
            {
                score += _bonus;
                Console.WriteLine($"Checklist completed! Bonus: {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine("This checklist goal is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _targetCount;
    }

    public override string GetStatus()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} {_name} ({_description}) -- Completed {_timesCompleted}/{_targetCount} times";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_targetCount},{_bonus},{_timesCompleted}";
    }
}
