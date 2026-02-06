
var rectangle1 = new Rectangle(5, 10);
rectangle1.DisplayInfo();

var rectangle2 = new Rectangle(7, 3);
rectangle2.DisplayInfo();

class Rectangle
{
    private double _width;
    private double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public double GetArea() => _width * _height;

    public double GetPerimeter() => 2 * (_width + _height);

    public void DisplayInfo() =>
        Console.WriteLine($"Rectangle - Width: {_width}, Height: {_height}, Area: {GetArea()}, Perimeter: {GetPerimeter()}");
}
