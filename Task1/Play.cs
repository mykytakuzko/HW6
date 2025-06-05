namespace Task1;

public class Play
{
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

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
    }

    public override string ToString()
    {
        return $"Name: {Name}\nAuthorName: {AuthorName}\nGenre: {Genre}\nYear: {Year}";
    }
}