int Vvod (string message)
{
Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
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
int str = Vvod("Введите индекс строки");
int stolb = Vvod("Введите индекс столбца");
int[,] number = new int[4, 4];
FillArray(number);
PrintArray(number);
if (str < number.GetLength(0) && stolb < number.GetLength(1))
{
    Console.WriteLine(number[str, stolb]);
}
else
{
    Console.WriteLine($"Элемент под индексами строки {str} и столбца {stolb} отсутствует");
}