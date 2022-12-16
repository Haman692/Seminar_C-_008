// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Factorial(int number)
{
    int x = 1;
    for (int i = 1; i <= number; i++)
    {
        x *= i;
    }
    return x;
}

void PrintTringl(int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j <= (size - i); j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j)));
        }
        Console.WriteLine();
    }

}
int size = AddNumber("Введите размер треугольника паскаля");
PrintTringl(size);