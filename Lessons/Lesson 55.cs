int [] numbers = new int[] {10,20,30,40,50};

var sum=0;

for(int i = 0; i < numbers.Length; i++)
{
    sum+=numbers[i];
}

Console.WriteLine($"Total:{sum}");