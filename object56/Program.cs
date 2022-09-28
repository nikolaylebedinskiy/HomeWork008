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

int LineMinSum(int[,] array)
{
    int minSum = array[0, 0];
    int lineMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
            {
                minSum = sum;
                lineMin = i;
            }
    }
    return lineMin + 1;
}

int[,] myarray = GenerateArray(6, 3, 0, 10);
PrintArray(myarray);
System.Console.WriteLine($"Строка с минимальной суммой:  {LineMinSum(myarray)}");
