namespace Task1;

public class Play
{
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }
    private FileStream fileStream;

    ~Play()
    {
        Console.WriteLine("The object is decreasing");
    }
    
    public Play() {}

    public Play(string name, string authorName, string genre, int year)
    {
        Name = name;
        AuthorName = authorName;
        Genre = genre;
        Year = year;
        fileStream = new FileStream("../../../Plays.txt", FileMode.Append, FileAccess.Write);
    }
    
    public void Dispose()
    {
        if (fileStream != null)
        {
            fileStream.Dispose();
            fileStream = null;
        }
    }

    public void WritePlayToFile()
    {
        string text = this.ToString() + Environment.NewLine;
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(text);
        
        fileStream.Write(bytes, 0, bytes.Length);
    }

    public override string ToString()
    {
        return $"Name: {Name}\nAuthorName: {AuthorName}\nGenre: {Genre}\nYear: {Year}";
    }
}