
class Program
{
    static void ShowFigureInfo(Figure figure)
    {
        figure.Print();
    }

    static void Main()
    {
        List<Figure> figures = new List<Figure>
        {
            new Triangle(0, 0, 3, 0, 0, 4),
            new Triangle(1, 1, 4, 1, 1, 5)
        };

        foreach (var figure in figures)
        {
            ShowFigureInfo(figure);
        }
    }
}
