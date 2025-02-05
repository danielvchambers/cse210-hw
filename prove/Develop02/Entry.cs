public class Entry
{
    List<string> prompts = new List<string>();
    Random r = new Random();
    public string _entry = "";
    public string _location = "";
    public string _dateText = "";
    public string _prompt = "";
    public Entry()
    {
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
    }
    public void GivePrompt()
    {
        int index = r.Next(prompts.Count);
        _prompt = prompts[index];
        Console.WriteLine($"prompt: {_prompt}");
    }
    public void GetTime()
    {
        DateTime date = DateTime.Now;
        _dateText = date.ToShortDateString();
    }
    public void GetEntry()
    {
        Console.Write("> ");
        _entry = Console.ReadLine();
    }
    public void GetLocation()
    {
        Console.Write("What is your Location? ");
        _location = Console.ReadLine();
    }

}
