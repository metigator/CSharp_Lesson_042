void DecideEvenOddV2(int number)
{
    if (number % 2 == 0)
        Console.WriteLine($"{number} is Even");
    else
        Console.WriteLine($"{number} is Odd");
}

Console.WriteLine("Hello, World!");
DecideEvenOdd(9);
DecideEvenOdd(10);


void DecideEvenOdd(int number)
{
    if (number % 2 == 0)
        Console.WriteLine($"{number} is Even");
    else
        Console.WriteLine($"{number} is Odd");
}