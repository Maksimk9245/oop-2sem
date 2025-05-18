public class TextContainer
{
    private List<TextLine> lines = new();

    public void AddLine(TextLine line) => lines.Add(line);
    public void RemoveLine(int index) => lines.RemoveAt(index);
    public void ShowAll()
    {
        foreach (var line in lines)
            Console.WriteLine(line.GetContent());
    }
}
