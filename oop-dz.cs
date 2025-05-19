using System;

class CharArrayWrapper
{
    private char[] characters;

    public CharArrayWrapper(char[] input)
    {
        characters = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
            characters[i] = input[i];
    }

    public char this[int index]
    {
        get
        {
            if (index >= 0 && index < characters.Length)
                return char.ToUpper(characters[index]);
            else
                throw new IndexOutOfRangeException();
        }
        set
        {
            if (index >= 0 && index < characters.Length)
                characters[index] = value;
            else
                throw new IndexOutOfRangeException();
        }
    }

    public int VowelCount
    {
        get
        {
            int count = 0;
            foreach (char c in characters)
                if ("AEIOUYАЕЁИОУЫЭЮЯaeiouyаеёиоуыэюя".Contains(c))
                    count++;
            return count;
        }
    }
}

class Program
{
    static void Main()
    {
        char[] input = { 'a', 'б', 'Е', 'ю', 'z' };
        CharArrayWrapper wrapper = new CharArrayWrapper(input);

        for (int i = 0; i < input.Length; i++)
            Console.Write(wrapper[i] + " ");
        
        Console.WriteLine("\n" + wrapper.VowelCount);
    }
}
