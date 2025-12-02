var words = new List<string>
{
    "one",
    "two",
};

Console.WriteLine("Count of elements is: "+words.Count);

foreach(var word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine();
Console.WriteLine("Removing an item");

words.Remove("two");
foreach(var word in words)
{
    Console.WriteLine(word);
}


var moreWords = new[] {"three","four","five"};
words.AddRange(moreWords);

Console.WriteLine();

foreach(var word in words)
{
    Console.WriteLine(word);
}
