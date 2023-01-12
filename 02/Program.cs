Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");


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

int GetSumNumbers(int number)
{
    int sum = 1;
    while (number > 0)
    {
        sum = sum * number;
        number--;
    }
    return sum;
}
