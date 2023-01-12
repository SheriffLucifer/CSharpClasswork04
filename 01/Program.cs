Console.Clear();
int number = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int getNumber = GetNumber(number);
Console.WriteLine($"{number} -> {getNumber}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetNumber(int number)
{
    int i = 0;
    while (number > 0)
    {
        number = number / 10;
        i++;
    }
    return i;
}

