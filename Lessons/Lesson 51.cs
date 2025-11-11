int userNumber;

do
{
    Console.WriteLine("Enter a number larger than 10");
    string userInput = Console.ReadLine();
    if (userInput == "stop")
    {
        break;
    }
    userNumber = int.Parse(userInput);
} while (userNumber <= 10);

Console.WriteLine("The loop is finished");