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
while (true)
{
    int number = GetNumberFromConsole("Введите день недели.");
    if (number >= 6 && number <= 7)
    {
        Console.WriteLine("Выходной день");
        break;
    }
    if (number >= 1 && number <= 5)
    {
        Console.WriteLine("Рабочий день");
        break;
    }
    else
    {
        Console.WriteLine("неверный ответ");
    }
}