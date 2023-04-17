// Задача 23:
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputInt()
{
    Console.WriteLine("Введите целое число");
    bool isNumber = int.TryParse(Console.ReadLine(), out int number);
    if (isNumber)
    {
        return number;
    }
    else 
    {
         Console.WriteLine("ERROR: Некорректное значение");
        return -1;
    }
}

int number = InputInt();

int[] GetTableOfSqures(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = (int)(Math.Pow(i + 1, 2));
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("Таблица кубов чисел от 1 до "+number+ ": ");
    for (int i = 0; i < number; i++)
    {
        Console.Write(+array[i]+" ");
    }
}

int[] squaresTable = GetTableOfSqures(number);
PrintArray(squaresTable);