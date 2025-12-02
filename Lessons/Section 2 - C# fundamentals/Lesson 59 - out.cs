var numbers = new[] {10,-8,2,12,-17};
int nonPositiveCount;
var onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount);

foreach (var positiveNumber in onlyPositive)
{
    Console.WriteLine(positiveNumber);
}
Console.WriteLine("Count of non positive: " + nonPositiveCount);

List<int> GetOnlyPositive(
    int[] numbers, out int countOfNonPositive)
{
    var result = new List<int>();
    countOfNonPositive = 0; 

    foreach (int number in numbers)
    {
        if (number > 0)
        {
            result.Add(number);
        }
        else
        {
            countOfNonPositive++; 
        }
    }
    return result;
}
