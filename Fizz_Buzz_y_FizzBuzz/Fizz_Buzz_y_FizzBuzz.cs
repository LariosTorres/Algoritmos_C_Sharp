IEnumerable<int> numero = Enumerable.Range(1, 1000);

foreach (int num in numero)
{
    if (num % 3 == 0 && num % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (num % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (num % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(num);
    }
}
