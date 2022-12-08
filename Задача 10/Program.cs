int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    number = -number; // number * (-1) 
}

if (80 <= number && number <= 999)
{
    int secondDigit = number / 10 % 10;
    Console.WriteLine(secondDigit);
}
