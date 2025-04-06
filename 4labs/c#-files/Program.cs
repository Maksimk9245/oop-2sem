using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть рядок:");
        string input = Console.ReadLine();

        FormattedRow row = new FormattedRow(input);
        row.PrintInfo();
    }
}
