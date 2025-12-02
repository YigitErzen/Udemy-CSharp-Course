Console.WriteLine("Hello!");

Console.WriteLine("Input the first number:");
string userInput1 = Console.ReadLine();

int number1 = int.Parse(userInput1);

Console.WriteLine("Input the second number:");
string userInput2 = Console.ReadLine();

int number2 = int.Parse(userInput2);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubstract numbers");
Console.WriteLine("[M]ultiply numbers?");

string userChoice = Console.ReadLine();

if (userChoice == "a" || userChoice == "A")
{
    int sum = number1 + number2;
    Console.WriteLine(number1 + " + " + number2 + " = " + sum);
}
else if (userChoice == "s" || userChoice == "S")
{
    int substraction = number1 - number2;
    Console.WriteLine(number1 + " - " + number2 + " = " + substraction);
}
else if (userChoice == "m" || userChoice == "M")
{
    int multiplication = number1 * number2;
    Console.WriteLine(number1 + " * " + number2 + " = " + multiplication);
}
else
{
    Console.WriteLine("Invalid choice!");
}

Console.WriteLine("Press any key to close");
Console.ReadKey();