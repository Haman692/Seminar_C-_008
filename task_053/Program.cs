// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write("[" + arr[i, j] + "]");
        }
        System.Console.WriteLine();
    }
}

void FillMatrixRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int lines = AddNumber("Enter the number of lines");
int colums = AddNumber("Enter the number of colums");
int[,] matrix = new int[lines, colums];
FillMatrixRandomNumbers(matrix);
PrintMatrix(matrix);

int i = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    int buffer = matrix[i, j];
    matrix[i, j] = matrix[matrix.GetLength(0) - 1, j];
    matrix[matrix.GetLength(0) - 1, j] = buffer;
}
System.Console.WriteLine();
PrintMatrix(matrix);