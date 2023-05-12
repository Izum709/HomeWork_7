// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

string FindNumber( int[,] massive, int findI, int findJ)
{ 
    string find = string.Empty;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j <massive.GetLength(1); j++)
        {
            if(i == findI & j == findJ) return  ($"Искомый элемент: {find + massive[i,j]}");
             
        }
    }
     return "Tакого элемента в массиве нет";
     
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
int findI =EnterData("Введите findI : ");
int findJ =EnterData("Введите findJ : ");
Console.Write($"[{findI},{findJ}] -> ");
Console.WriteLine(FindNumber(array, findI, findJ));
