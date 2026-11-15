public class Scripture
{
    private Reference _reference ;
    private List<Word> _words;

    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string [] wordArray = text.Split(' ');

        foreach(string wordText in  wordArray)
        {
            Word newWord = new Word(wordText);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount <numberToHide && !IsCompletelyHidden())
        {
            int randomIndex = random.Next(_words.Count);

            if (!_words[randomIndex].isHidden())
            {
                _words[randomIndex].Hide();
                hiddenCount++;
            }
        }
    }
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " "; 
        }

        return displayText.TrimEnd();
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return false;
    }


}