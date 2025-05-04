class Program
{
    static void Main()
    {
        TextContainer container = new();

        var line1 = new TextLine("hello world");
        var line2 = new TextLine("c# is FUN");

        container.AddLine(line1);
        container.AddLine(line2);

        Console.WriteLine(line1.CapitalizeWords()); 
        Console.WriteLine(line2.ToLowerCase());

        container.ShowAll();
    }
}
