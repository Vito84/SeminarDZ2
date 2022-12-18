int GetNumberFromConsole(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("ВЫ ввели не число.");
            Console.WriteLine("__________________");
        }
    }

    return result;
}

int number = GetNumberFromConsole("Введите число.");
string numberString = $"{number}";
if (numberString.Length > 2)
{
    Console.WriteLine($"Третье число равно {numberString[2]}");
}
else
{
    Console.WriteLine("Третьего числа нет");
}
