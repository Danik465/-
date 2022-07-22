

enum Color
{
    Red, Blue, Green, Orange, Yellow
}

class Point
{
    public int X;
    public int Y;

    public Color color;
}

class Program
{
    static void Main(string[] args)
    {
        Point point = new Point();

        point.X = 4;
        point.Y = 2;
        point.color= Color.Blue;

        Point point2 = new Point();

        point2.X = 4;
        point2.Y = 2;

        Console.WriteLine($"{point.X} , {point.Y} , Color {point.color}");
       
    }
}