// Задача 1: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

double[,] CreateArray(int row, int column)
{
    var array = new double[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * 100;
        }
    }
    return array;
}

void PRINT(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:f1}" + "\t");
        }
        System.Console.WriteLine();
    }
}

int row = Prompt("Kolichestvo strok -> ");
int column = Prompt("Kolichestvo stolbcov -> ");
double[,] array = CreateArray(row, column);
PRINT(array);
