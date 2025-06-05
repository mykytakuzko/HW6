namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Shop firstShop = new Shop("Novus", "Хрещатик", TypeOfShop.Economic);
        Console.WriteLine(firstShop);
        firstShop.WriteShopToFile();
        firstShop.Dispose();
    }
}