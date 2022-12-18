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
int number = GetNumberFromConsole("Введите трехзначное число.");
int inference = (number / 10) % 10;
Console.WriteLine(inference);