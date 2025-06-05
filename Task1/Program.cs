namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        CreateAndShowPlay();
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
        
        Console.WriteLine("Above must be a string from destructor");
    }

    private static void CreateAndShowPlay()
    {
        Play firstPlay = new Play("Test", "Ivan", "Comedy", 1989);
        Console.WriteLine(firstPlay);
        
        firstPlay.WritePlayToFile();
        firstPlay.Dispose();
    }
}