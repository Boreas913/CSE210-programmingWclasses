public class Scripture
{
    private List<Word> _list = new List<Word>();
    private Reference _reference;


    public Scripture(Reference reference, string verseText)
    {
        _reference = reference;
        string[] verseWords = verseText.Split(' ');
        foreach (string word in verseWords)
        {
            _list.Add(new Word(word, false));
        }
        
    }
    public void HideRandomWords(int toHide)
    {
        if (IsWholeThingHidden())
        {
            return;
        }
        int hiddenThisTurn = 0;
        while (hiddenThisTurn < toHide)
        {
            int index = Random.Shared.Next(_list.Count);
            if (!_list[index].IsHidden())
            {
                _list[index].Hide();
                hiddenThisTurn+=1;
            }
            if (IsWholeThingHidden()) break;
        }
    }
    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        return $"{reference} {string.Join(" ", _list.Select(w => w.GetDisplayText()))}";
    }

    public Boolean IsWholeThingHidden()
    {
        foreach (Word word in _list)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}