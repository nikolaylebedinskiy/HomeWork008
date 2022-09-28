int[,] GenerateArray(int rows, int columns, int minrnd, int maxrnd)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minrnd, maxrnd + 1);
        }
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] MatrixsProdukt(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int n = 0; n < array1.GetLength(1); n++)
            {
                array3[i, j] += array1[i, n] * array2[n, j];
            }
        }
    }
    return array3;
}

int[,] myarray1 = GenerateArray(3, 4, 0, 5);
PrintArray (myarray1);
int[,] myarray2 = GenerateArray(4, 3, 0, 5);
PrintArray(myarray2);
if(myarray1.GetLength(1) != myarray2.GetLength(0))
{
    System.Console.WriteLine("Данные матрицы перемножать нельзя");
}
else
{
System.Console.WriteLine("Произведение матриц: ");
PrintArray(MatrixsProdukt(myarray1, myarray2));
}