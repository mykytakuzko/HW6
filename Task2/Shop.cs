namespace Task2;

public class Shop : IDisposable
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public TypeOfShop? Type { get; set; }
    private FileStream? fileStream;
    
    public Shop() {}

    public Shop(string name, string address, TypeOfShop type)
    {
        Name = name;
        Address = address;
        Type = type;
        fileStream = new FileStream("../../../Shops.txt", FileMode.Append, FileAccess.Write);
    }

    public void Dispose()
    {
        if (fileStream != null)
        {
            fileStream.Dispose();
            fileStream = null;
        }
    }

    public void WriteShopToFile()
    {
        string text = this.ToString() + Environment.NewLine;
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(text);
        
        fileStream.Write(bytes, 0, bytes.Length);
    }

    public override string ToString()
    {
        return $"Name: {Name}\nAddress: {Address}\nType: {Type}";
    }
}

public enum TypeOfShop
{
    Food,
    Economic,
    Clothes,
    Footwear
}