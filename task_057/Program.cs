// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void Permen(int[,] arr, int value)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == value)
            {
                count++;
            }
        }
    }
    if(count > 0)
        System.Console.WriteLine($"В масиве чисало {value} встречаються {count} раз");
    if (value < 10)
    {
        Permen(arr, value + 1);
    }
}

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


Permen(matrix, 0);