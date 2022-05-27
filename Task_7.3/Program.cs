// Сформировать трехмерный массив не повторяющимися двузначными числами,
// показать его построчно на экран выводя индексы соответствующего элемента

void FillThreeMassive(int[,,] A)
{
    int x = A.GetLength(0);
    int y = A.GetLength(1);
    int z = A.GetLength(2);
    int a = 11;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                A[i, j, k] = a;
                a++;
            }
        }
    }
}

void PrintThreeMassive(int[,,] A)
{
    int x = A.GetLength(0);
    int y = A.GetLength(1);
    int z = A.GetLength(2);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                Console.WriteLine($"A[{i}, {j}, {k}] = {A[i, j, k]}  ");
            }
        }
    }
}

int[,,] matr = new int[3, 5, 2];
int x = matr.GetLength(0);
int y = matr.GetLength(1);
int z = matr.GetLength(2);
int a = x * y * z;
if (a >= 8 && a <= 89)

FillThreeMassive(matr);
PrintThreeMassive(matr);


