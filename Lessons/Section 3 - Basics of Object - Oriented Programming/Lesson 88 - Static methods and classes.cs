Console.WriteLine(Calculator.Add(5,10));
Console.WriteLine(Calculator.Subtract(5,10));
Console.WriteLine(Calculator.Multiply(5,10));
Console.WriteLine(Calculator.Divide(5,10));

static class Calculator
{
    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;
    public static double Divide(double a, double b) => a / b;
}

