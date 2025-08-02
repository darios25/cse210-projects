public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to start...");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine("Great work!");
        ShowSpinner(2);
        Console.WriteLine($"You've completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    public int GetDuration() => _duration;

    protected void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rPlease wait... {i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}


