
int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    number = -number; // number * (-1) 
}

if (number < 100)
{
    Console.WriteLine("3 цыфры нету");
}
else
{

    while (number > 999)
    {
        number = number / 10;
    }
    int thierdDigit = number % 10;
    Console.WriteLine(thierdDigit);
    }