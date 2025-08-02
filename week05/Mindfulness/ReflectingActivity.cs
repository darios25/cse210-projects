public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly altruistic."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done something similar before?",
        "How did you start?",
        "How did you feel when you completed it?",
        "What made this experience different?",
        "What did you enjoy most?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you remember this experience in the future?"
    };

    public ReflectingActivity() : base("Reflection", "This activity will help you reflect on moments in your life when you have demonstrated strength and resilience.") { }

    public void Run()
    {
        Start();
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }

        End();
    }

    private string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)];
    private string GetRandomQuestion() => _questions[new Random().Next(_questions.Count)];
}


