using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        File.Delete(file);
        using (StreamWriter writer = File.AppendText(file))
        {
            foreach (Entry entry in _entries)
            {
                string date = entry._date;
                string prompt = entry._promptText;
                string text = entry._entryText;

                writer.WriteLine($"{date},{prompt},{text}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string [] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Entry newEntry = new Entry();

            string [] values;

            values = line.Split(",");

            string date = values[0];
            string prompt = values[1];
            string text = values[2];

            newEntry._date = date;
            newEntry._promptText = prompt;
            newEntry._entryText = text;

            _entries.Add(newEntry);
        }
    }
}