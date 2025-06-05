namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        ShowDestructorWork();
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
        
        Console.WriteLine("Above must be a string from destructor");
    }

    private static void ShowDestructorWork()
    {
        Shop firstShop = new Shop("Novus", "Хрещатик", TypeOfShop.Economic);
        Console.WriteLine(firstShop);
        
        firstShop.WriteShopToFile();
        firstShop.Dispose();
    }
}