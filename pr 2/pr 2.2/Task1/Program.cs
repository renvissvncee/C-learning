int[,] createRandomMatrix(int n, int m, int a, int b)
{
    int[,] matrix = new int[n, m];
    Random rnd = new Random(255);
    int[] temp = new int[m];
    for (int i = 0; i < n * m; i++)
    {
        matrix[i / m, i % m] = rnd.Next(a, b);
    }
    return matrix;
}

int[,] createMatrix(int n, int m, int[] values)
{
    int[,] matrix = new int[n, m];
    int[] temp = new int[m];
    for (int i = 0; i < n * m; i++)
    {
        matrix[i / m, i % m] = values[i];
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0); 
    int cols = matrix.GetLength(1); 

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размерность матрицы (пример: '3 4'): ");
int[] dimension = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

Console.WriteLine("Как создать матрицу?");
Console.WriteLine("1. Введу свои числа");
Console.WriteLine("2. Случайные числа");
int[,] Matrix = new int[dimension[0], dimension[1]];

if (Console.ReadLine() == "2")
{
    Console.Write("Введите ограничение значений (пример: '1 10'): ");
    int[] borders = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
    Matrix = createRandomMatrix(dimension[0], dimension[1], borders[0], borders[1]);
}
else
{
    int[] values = new int[dimension[0] * dimension[1]];
    Console.WriteLine("Введите значения (каждую новую строку значений с новой консольной строки): ");
    for (int i = 0; i < dimension[0]; i++)
    {
        int[] temp = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        for (int j = 0; j < dimension[1]; j++)
        {
            values[(i * dimension[1]) + j] = temp[j];
        }
    }
    Matrix = createMatrix(dimension[0], dimension[1], values);
}

Console.WriteLine("Получившаяся матрица:");
PrintMatrix(Matrix);
