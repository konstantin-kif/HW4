// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран.
// И ищет второй максимум (элемент меньше максимального, но больше всех остальных).

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

// Функция генерации массива
int[] FillArray(int Length, int HighLimit, int LowLimit)
{
    int[] array = new int[Length];
    int i = 0;
    while (i < array.Length)
    {
        array[i] = new Random().Next(HighLimit, LowLimit);
        i++;
    }
    return array;
}

// Функция ввывода массива
void PrintArray(int[] array)
{
    int count = 0;
    while (count < array.Length)
    {
        Console.Write($"{array[count]} \t");
        count++;
    }
}

int SecondMaxNumber(int[] arrayInput)
{
    const int zeroElement = 0;
    const int secondElement = 1;
    int numberMax = arrayInput[zeroElement];
    int numberSecondMax = 0;
    for (int index = secondElement; index < arrayInput.Length; index++)
    {
        if (arrayInput[index] >= numberMax)
        {
            numberSecondMax = arrayInput[index] >= numberMax ? numberMax : numberSecondMax;
            numberMax = arrayInput[index];
        }
        else if (arrayInput[index] > numberSecondMax)
        {
            numberSecondMax = arrayInput[index];
        }
    }
    return numberSecondMax;
}

int LenArray = Prompt("Введите число N, соответствующее количеству элементов в массиве: ");
int LowLimit = Prompt("введите число, соответствующее нижней границы диапозона: ");
int HighLimit = Prompt("                             верхней границы диапозона: ");
int[] set = FillArray(LenArray, HighLimit, LowLimit);
PrintArray(set);
Console.WriteLine($"Второй максимум -> {SecondMaxNumber(set)}");
