// Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

int ExponentiationOfNumber(int value1, int value2)
{
    int result = 1;
    for (int i = 0; i < value2; i++)
    {
        result = result * value1;
    }
    return result;
}

int numberA = Prompt("Введите значение числа А: ");
int numberB = Prompt("Введите значение числа В: ");
if (numberB < 0)
{
    System.Console.WriteLine($"Некоректный ввод");
}
else 
{
System.Console.WriteLine($"{numberA}, {numberB} -> {ExponentiationOfNumber(numberA, numberB)}");
}