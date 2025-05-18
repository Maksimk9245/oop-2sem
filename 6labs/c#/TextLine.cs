public class TextLine : ICaseChanger
{
    private string content;

    public TextLine(string text)
    {
        content = text;
    }

    public string ToUpperCase() => content.ToUpper();
    public string ToLowerCase() => content.ToLower();
    public string CapitalizeWords()
    {
        return string.Join(" ", content
            .Split(' ')
            .Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
    }

    public string GetContent() => content;
    public void SetContent(string newContent) => content = newContent;
}
