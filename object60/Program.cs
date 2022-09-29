int[,,] GenerateArray3D()
{
    int[,,] array = new int[2, 2, 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); i++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array  [i, j, k] = (int)(Math.Pow(i + 1, 3) + Math.Pow(j + 2, 3) + Math.Pow(k + 3, 3));
            }
        }
    }
    return array;
}

void PrintArray3D(int[,,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); i++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.WriteLine($"{array[i, j, k], 3}({i}, {j}, {k})");

            }
            System.Console.WriteLine();    
        }
    }
}
PrintArray3D(GenerateArray3D());
