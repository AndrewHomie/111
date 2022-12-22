// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3;
int n = 4;
double[,] twodimArray = new double[m,n];
Random rdn = new Random();

void PrintArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine($"{matr[i, j]}");
        }
        Console.WriteLine();
    }
}
void FillArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           matr[i, j] = Convert.ToDouble(rdn.Next(-10, 10));
        }
    }
}

FillArray(twodimArray);
Console.WriteLine();
PrintArray(twodimArray);