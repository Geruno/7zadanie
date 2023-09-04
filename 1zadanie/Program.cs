int Vvod (string message)
{
Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int m = Vvod("Введите значение переменной m");
int n = Vvod("Введите значение переменной n");
double[ , ] number = new double[m, n];
FillArray(number);
PrintArray(number);