// Спирально заполнить двумерный массив

int[,] spiral = new int[5, 5];
int m = spiral.GetLength(0);
int n = spiral.GetLength(1);
int s = 1;

for (int j = 0; j < n; j++)
{
    spiral[0, j] = s;
    s++;
}

for (int i = 1; i < m; i++)
{
    spiral[i, n - 1] = s;
    s++;
}

for (int j = n - 2; j >= 0; j--)
{
    spiral[m - 1, j] = s;
    s++;
}

for (int i = m - 2; i > 0; i--)
{
    spiral[i, 0] = s;
    s++;
}