public class Word
{
    private string _word;
    private bool _isHidden = false;
    public Word(string word)
    {
        _word = word;
    }
    public string GetWord()
    {
        return _word;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public bool GetHidden()
    {
        return _isHidden;
    }
    public void HideWord()
    {
        _isHidden = true;
    }
}
