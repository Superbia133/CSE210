public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent(ref int score);
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string Serialize();

    public static Goal Deserialize(string data)
    {
        string[] parts = data.Split(":");
        string type = parts[0];
        string[] values = parts[1].Split(",");

        return type switch
        {
            "SimpleGoal" => new SimpleGoal(values[0], values[1], int.Parse(values[2]), bool.Parse(values[3])),
            "EternalGoal" => new EternalGoal(values[0], values[1], int.Parse(values[2])),
            "ChecklistGoal" => new ChecklistGoal(values[0], values[1], int.Parse(values[2]), int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5])),
            _ => throw new Exception("Unknown goal type")
        };
    }
}
