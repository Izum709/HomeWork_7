// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void SumColumns(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double average = sum / array.GetLength(0);
        Console.Write($"{average:F1}; ");
    }
}

void PrintMassive(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array [i, j]}]");
        }
        Console.WriteLine();
    }
}

int[,] FillMassive(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (Convert.ToInt32(Console.ReadLine()));
}

int m =EnterData("Введите количество строк: ");
int n =EnterData("Введите количество столбцов : ");
int[,] array = FillMassive(m, n);
PrintMassive(array);
SumColumns(array);