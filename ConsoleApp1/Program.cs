class Rectangle
{
    public int x = 10, y = 20;
    public int GetAreaRectangle(int a, int b)
    {
        return a * b;
    }
}

class Square : Rectangle
{
    public int GetAreaSquare(Rectangle rectangle) {
        return rectangle.GetAreaRectangle(x, y);
    }

    static void Main(string[] args)
    {
        Square square = new Square();
        int area = square.GetAreaSquare(square);
        Console.WriteLine($"Area of the square: {area}");
    }
}