// Exceeds requirements: Added a custom "Mood" (Humor) tracking feature to each 
// journal entry. This extra piece of data is captured from the user during creation, 
// correctly formatted and saved using the pipe (|) separator, loaded back into the 
// application, and displayed alongside the date, prompt, and entry text.

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
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._mood} ");
            }
        }
    }

    public void LoadFromFile(string file)
    {
       _entries.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            newEntry._mood = parts[3];

            _entries.Add(newEntry);
        } 
    }
}