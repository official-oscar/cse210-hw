public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string underscores = "";
            foreach (char c in _text)
            {
                if (char.IsLetter(c))
                    underscores += "_";
                else
                    underscores += c;
            }
            return underscores;
        }
        else
        {
            return _text;
        }
    }
}