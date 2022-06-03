//Найти произведение двух матриц
void PrintArray(int[,] arrayforprint)   ///метод печати массива
{
    for (int i = 0; i < arrayforprint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayforprint.GetLength(1); j++)
        {
            Console.Write($"{arrayforprint[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultipleArray(int[,] array1, int[,] array2)  ///метод перемножения
{
    if (array1.GetLength(0) == array2.GetLength(0) && array1.GetLength(1) == array2.GetLength(1))
    {
        int[,] multiplArray = new int[array1.GetLength(0),array1.GetLength(1)];
        for (int i = 0; i < multiplArray.GetLength(0); i++)
        {
            for (int j = 0; j < multiplArray.GetLength(1); j++)
            {
                multiplArray[i,j] = array1[i,j] * array2[i,j];
            }
        }
        return multiplArray;
    }
    else
        {
            Console.WriteLine("Матрицы не одинакового размера");
            Console.WriteLine();
            return null;
        }
}

Console.Write("Введите количество строк первой матрицы = ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов первой матрицы = ");
int m = int.Parse(Console.ReadLine() ?? "0");

int[,] array1 = new int[n, m];
for (int i = 0; i < array1.GetLength(0); i++)
    for (int j = 0; j < array1.GetLength(1); j++) array1[i, j] = new Random().Next(1, 10);


Console.Write("Введите количество строк второй матрицы = ");
int n1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов второй матрицы = ");
int m1 = int.Parse(Console.ReadLine() ?? "0");

int[,] array2 = new int[n1, m1];
for (int i = 0; i < array2.GetLength(0); i++)
    for (int j = 0; j < array2.GetLength(1); j++) array2[i, j] = new Random().Next(1, 10);

PrintArray(array1);
PrintArray(array2);

int[,] newArr = MultipleArray(array1, array2);
PrintArray(newArr);