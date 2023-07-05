// Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rows = Prompt("Введите количество строк: ");
int colums = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число для минимального диапазона значений: ");
int maxValue = Prompt("Введите число для максимального диапазона значений: ");
double [,] array = GetArray(rows, colums, minValue, maxValue);
PrintArray(array);



int Prompt (string messenge)
{
    Console.WriteLine (messenge);
    int number =int.Parse(Console.ReadLine());
    return number;
}

double[,] GetArray (int m, int n, int min, int max)
{
    Random rnd = new Random();
    double[,] result = new double[m, n];
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i, j] = Math.Round(rnd.NextDouble() * (maxValue - minValue) + minValue, 1);  // генерируем случайное число в диапазоне [minValue, maxValue] и округляем до двух знаков после запятой
        //    Console.Write($"{result[i,j]} ");
        }
        // Console.WriteLine();
        // Console.WriteLine();
    }
    return result;
}

void PrintArray(double[,]arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
               Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
