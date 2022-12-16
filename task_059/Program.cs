// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
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

int min1 = 0;
int min2 = 0;
int min = matrix[0, 0];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            min1 = i;
            min2 = j;
        }

    }
}
System.Console.WriteLine(matrix[min1, min2]);
System.Console.WriteLine(min1 + "; "+ min2);
System.Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i != min1 && j != min2)
            System.Console.Write("[" + matrix[i, j] + "]");
    }
    if (i != min1)
        System.Console.WriteLine();
}