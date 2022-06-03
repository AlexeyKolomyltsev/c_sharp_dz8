//В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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

int[,] DeleteRowColumn(int[,] array)  ///метод удаления
{
    int minI = 0; int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)   //находим индексы минимального элемнта
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minI, minJ])
            {
                minI = i;
                minJ = j;
            }
        }
    }
    int[,] arrDel = new int[array.GetLength(0) - 1, array.GetLength(1) - 1]; //инициализируем новый массив на 1 меньше оригинала
    for (int i = 0; i < array.GetLength(0); i++)  //заполняем четвертями, выколотой границей будет точка minI, minJ
    {
        if (i < minI)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j < minJ)
                {
                    arrDel[i, j] = array[i, j];
                }
                if (j > minJ)
                {
                    arrDel[i, j - 1] = array[i, j];
                }
            }
        }
        if (i > minI)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j < minJ)
                {
                    arrDel[i - 1, j] = array[i, j];
                }
                if (j > minJ)
                {
                    arrDel[i - 1, j - 1] = array[i, j];
                }
            }
        }

    }
    return arrDel;
}

Console.Write("Введите количество строк = ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов = ");
int m = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[n, m];
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 10);


PrintArray(array);


int[,] newArr = DeleteRowColumn(array);
PrintArray(newArr);