using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the most interesting thing I saw today?",
        "What was the best moment of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the best activity I did today?",
        "If I could do one thing today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}


        
    


