void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
void ReversMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0);
        for (int i = 0; i < matrix.GetLength(0) / 2; i++)
    {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[n - 1 - i, j];
                matrix[n - 1 - i, j] = temp; 
            }
    }
}
Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ReversMatrix(matrix);
PrintMatrix(matrix);