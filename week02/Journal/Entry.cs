using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    public string ToCsv()
    {
        return $"\"{_date}\",\"{_prompt.Replace("\"", "\"\"")}\",\"{_response.Replace("\"", "\"\"")}\"";
    }

    public static Entry FromCsv(string line)
    {
        var parts = line.Split("\",\"");
        string date = parts[0].Trim('"');
        string prompt = parts[1].Trim('"');
        string response = parts[2].Trim('"');
        return new Entry(prompt, response) { _date = date };
    }
}


