public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent(ref int score)
    {
        score += _points;
        Console.WriteLine($"Progress recorded! You earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never marked complete
    }

    public override string GetStatus()
    {
        return $"[∞] {_name} ({_description})";
    }

    public override string Serialize()
    {
        return $"EternalGoal:{_name},{_description},{_points}";
    }
}
