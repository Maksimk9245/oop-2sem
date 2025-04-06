using System;

public class StringRow
{
    private readonly string value;

    public StringRow(string value)
    {
        this.value = value;
    }

    public string Value => value;

    public int GetLength()
    {
        return value.Length;
    }
}
