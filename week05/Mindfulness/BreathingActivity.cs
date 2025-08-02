public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by inhaling and exhaling slowly. Clear your mind and focus on your breathing.") { }

    public void Run()
    {
        Start();
        int duration = GetDuration();
        int cycleTime = 6; // 3 sec inhale + 3 sec exhale
        int cycles = duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Inhale...");
            ShowSpinner(3);
            Console.WriteLine("Exhale...");
            ShowSpinner(3);
        }

        End();
    }
}


