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
void SumSredArifm(int[,] matrix)
{
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double sum = 0; int s = matrix.GetLength(0);
            for(int i = 0; i < matrix.GetLength(0); i++) 
                    sum = sum + matrix[i, j];
        Console.Write($" {Math.Round((sum / s), 2)} ");
        }
}
Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.Write("Среднне арифметическое столбцов = ");
SumSredArifm(matrix);
