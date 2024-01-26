using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] strings;
        strings = text.Split(" ");

        foreach (string srt in strings)
        {
            Word word = new Word(srt);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            Random random = new Random();
            
            int index = random.Next(0, _words.Count);

            Word word = _words[index];
            word.Hide();
        }
    }
    public string GetDisplayText()
    {
        string scripture = "";
        string reference = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            scripture += word.GetDisplayText() + " ";
        }

        return $"{reference} {scripture}";
    }
    public bool IsCompletelyHidden()
    {
        bool isComplHidden = false;
        
        int hidden = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hidden ++;
            }
        }

        if (hidden == _words.Count)
        {
            isComplHidden = true;
        }
        
        return isComplHidden;
    }
}