var userChoice = Console.ReadLine();

bool isUserInputAbc = userChoice == "ABC";
bool isUserInputNotAbc = userChoice != "ABC";
bool isUserInputNotAbc2 = !(userChoice == "ABC");

var number = 10;

var isLargerThan5 = number > 5;
var isSmallerThan10 = number < 10;
var isLargerOrEqualTo10 = number >= 10;
var isSmallerOrEquelTo6 = number <= 6;

var is10Modula3EqualTo1 = 10 % 3 == 1;
var isEven = 10 % 2 == 0;

Console.WriteLine(isUserInputAbc);
Console.WriteLine(isUserInputNotAbc);
Console.WriteLine(isUserInputNotAbc2);
Console.WriteLine(isLargerThan5);
Console.WriteLine(isSmallerThan10);
Console.WriteLine(isSmallerOrEquelTo6);
Console.WriteLine(is10Modula3EqualTo1);
Console.WriteLine(isEven);
Console.WriteLine(isSmallerThan10);
