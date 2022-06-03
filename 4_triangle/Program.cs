// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
void PrintArrayStr(string[,] arrayforprint)   ///метод печати массива
{
    for (int i = 0; i < arrayforprint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayforprint.GetLength(1); j++)
        {
            Console.Write(arrayforprint[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] array)  ///заполняем массив
{
    array[0, array.GetLength(1) / 2] = 1;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) array[i, j] = array[i - 1, j + 1];
            else if (j == array.GetLength(1) - 1) array[i, j] = array[i - 1, j - 1];
            else array[i, j] = array[i - 1, j - 1] + array[i - 1, j + 1];
        }
    }
}

string[,] IntToStringArray(int[,] array) ///переводим массив из int в string для красоты
{
    string[,] strarr = new string[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0) strarr[i, j] = " ";
            else strarr[i, j] = array[i, j].ToString();
        }
    }
    return strarr;
}

Console.Write("Введите высоту треугольника = ");
int n = int.Parse(Console.ReadLine() ?? "0");
int m = n * 2 - 1;
int[,] array = new int[n, m];

FillArray(array);

string[,] stringArray = IntToStringArray(array);
PrintArrayStr(stringArray);