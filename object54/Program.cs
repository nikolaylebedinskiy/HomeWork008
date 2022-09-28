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

int[,] LineMaxMin(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1) - 1; j++)
        {
            int PositionMax = j;
            for (int k = j + 1; k < Array.GetLength(1); k++)
            {
                if(Array[i, k] > Array[i, PositionMax])
                {
                PositionMax = k;
                }
            }
        int exchenge = Array[i, j];
        Array[i, j] = Array[i, PositionMax];
        Array[i, PositionMax] = exchenge;
        }
    }
    return Array;
}

int[,] myarray = GenerateArray(4, 4, 0, 10);
PrintArray(myarray);
PrintArray(LineMaxMin(myarray));
