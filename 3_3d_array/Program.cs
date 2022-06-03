// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
void PrintArray(int[,,] arrayforprint)   ///метод печати массива
{
    for (int i = 0; i < arrayforprint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayforprint.GetLength(1); j++)
        {
            for (int k = 0; k < arrayforprint.GetLength(2); k++)
            {
                Console.Write($"{arrayforprint[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] FillArray(int n, int m, int l)
{
    int[,,] array = new int[n, m, l];
    if (n * m * l < 90)
    {
        int count = 10;
        
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = count;
                    count++;
                }
        return array;
    }
    else
    {
        Console.WriteLine("Слишком большая матрица, заполняем нулями");
        return array;
    }
}
Console.Write("Введите количество страниц = ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество строк = ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов  = ");
int l = int.Parse(Console.ReadLine() ?? "0");
int[,,] arrayForFill = FillArray(n,m,l);
PrintArray(arrayForFill);
