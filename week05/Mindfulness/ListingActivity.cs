public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are the people you admire?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "When did you feel the Holy Spirit this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life.") { }

    public void Run()
    {
        Start();
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("→ ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }

        Console.WriteLine($"You have listed {items.Count} items.");
        End();
    }

    private string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)];
}


