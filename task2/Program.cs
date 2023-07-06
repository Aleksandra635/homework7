// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> на этой позиции числа в массиве нет

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число для минимального диапазона значений: ");
int maxValue = Prompt("Введите число для максимального диапазона значений: ");
int mValue = Prompt("Введите значение позиции строки: ");
int nValue = Prompt("Введите значение позиции столбца: ");
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
int result = Position(array, mValue, nValue);
SearchPosition(mValue, nValue, result);



int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int m, int n, int min, int max)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(min, max);
        }
    }
    return array;
}

int Position(int[,] array, int posm, int posn)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == posm && j == posn)
            {
                return array[i, j];
            }
        }
    }
    return -1;

}

int SearchPosition(int rows, int columns, int result)
{
    if (result != -1)
    {
        Console.WriteLine($"Значение на позиции ({rows}, {columns}) равно {result}");
    }
    else
    {
        Console.WriteLine($"[{rows}, {columns}] --> на этой позиции числа в массиве нет");
    }
    return 0;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}



