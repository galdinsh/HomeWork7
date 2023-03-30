void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
    }
}

void PrintMatrix(int[,] matrix)
{   int m = 0, b = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
            m++;
        }
        Console.WriteLine();
        b++;
    }
    Console.Write("Введите искомую позицию элемента в массиве: ");
    int[] n = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
        if (n[0] > b || n[1] > m)
            Console.WriteLine("Такой позиции нет");
        else Console.WriteLine($"Искомы элемент в массиве = {matrix[n[0]-1, n[1]-1]}");    
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
