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

int[,] SpiralArray(int[,] array)
{
    int count = 1;
    int startRow = 0;
    int lastRow = array.GetLength(0) - 1;
    int startCol = 0;
    int lastCol = array.GetLength(1) - 1;
    while (startRow <= lastRow && startCol <= lastCol)
    {
        for (int j = startCol; j <= lastCol; j++)
        {
            array[startRow, j] = count;
            count++;
        }
        startRow++;
        for (int i = startRow; i <= lastRow; i++)
        {
            array[i, lastCol] = count;
            count++;
        }
        lastCol--;
        for (int j = lastCol; j>= startCol; j--)
        {
            array[lastRow, j] = count;
            count++;
        }
        lastRow--;
        for (int i = lastRow; i >= startRow; i--)
        {
            array[i, startCol] = count;
            count++;
        }
        startCol++;
    } 
    return array;
}

int[,] myarray = new int[4, 4];
PrintArray(SpiralArray(myarray));
