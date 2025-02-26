public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(string reference, string scripture)
    {
        string[] words = scripture.Split(" ");
        Reference _reference = new Reference(reference);

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public void DisplayScripture()
    {
        Console.Clear();
        Console.Write(_reference.GetReference());
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetWord()} ");
        }
    }
    public void HideRandomWords()
    {

    }
}
