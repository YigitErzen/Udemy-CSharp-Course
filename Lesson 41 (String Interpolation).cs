Console.WriteLine("Enter your name:");
var name = Console.ReadLine();

Console.WriteLine("Enter your age:");
var ageAsString = Console.ReadLine();

int age = int.Parse(ageAsString);

Console.WriteLine($"My name is  {name} and my age is: {age}");


int a = 5, b = 10;

Console.WriteLine($"{a} + {b} = {a + b}");