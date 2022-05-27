// В двумерном массиве целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

void FillTwoMassive(int[,] matrix)
{
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = new Random().Next(10, 99);
        }
    }
}

void PrintTwoMassive(int[,] matrix)
{
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void PrintTwoMassiveNoZeros(int[,] matrix, int[] Row)
{
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            if (matrix[i, j] != 0) Console.Write($"{matrix[i, j]}   ");
        }
        if(Row[i]==0) Console.WriteLine();
    }
}

int LowestElement(int[,] Array)
{
    int minValue = Array[0, 0];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] < minValue) minValue = Array[i, j];
        }
    }
    return minValue;
}

int Row(int[] Array)
{
    int r = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        {
            if (Array[i] == 1) r = i;
        }
    }
    return r;
}

int Column(int[] Array)
{
    int c = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        {
            if (Array[i] == 1) c = i;
        }
    }
    return c;
}

int[,] array = new int[10, 5];
FillTwoMassive(array);
PrintTwoMassive(array);
Console.WriteLine();

int[] rows = new int[array.GetLength(0)];
int[] columns = new int[array.GetLength(1)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == LowestElement(array))
        {
            rows[i] = 1;
            columns[j] = 1;
        }
    }
}

Console.WriteLine($"lowest value = {LowestElement(array)}");
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == Row(rows)) array[i, j] = 0;
    }   
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j == Column(columns)) array[i, j] = 0;
    }   
}

PrintTwoMassiveNoZeros(array, rows);
