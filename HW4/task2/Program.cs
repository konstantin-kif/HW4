//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

int SumOfDigitsOfNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

int value = Prompt("Введите значение числа: ");
if (value >= 0)
{
    System.Console.WriteLine($"{value} -> {SumOfDigitsOfNumber(value)}");
}
