

string userInput = Console.ReadLine();

if (userInput == "A")
{
    writeSelectedOption("Alex");
}
else if (userInput == "B")
{
    writeSelectedOption("Bella");
}
else if (userInput == "L")
{
    writeSelectedOption("Lily");
}
else
{
    writeSelectedOption("Nobody selected!");
}
    void writeSelectedOption(string selectedOption)
    {
        Console.WriteLine("Selected Person: " + selectedOption);
    }