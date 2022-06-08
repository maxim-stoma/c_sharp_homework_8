int[,] GetRandomArray(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray(int[,] arrayToPrint)
{
    Console.WriteLine();
    Console.Write("[ ]\t");
    const int startIndex = 65;
    for (int columnName = startIndex + 0; columnName < startIndex + arrayToPrint.GetLength(1); columnName++)
    {
        Console.Write($"[{((char)columnName)}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrixOne, int[,] matrixTwo, int finalRow, int finalColumn)
{
    int[,] resultMatrix = new int[finalRow, finalColumn];
    for (int i = 0; i < finalRow; i++)
    {
        for (int j = 0; j < finalColumn; j++)
        {
            for (int k = 0; k < finalRow; k++)
            {
                resultMatrix[i, j] += (matrixOne[i, k] * matrixTwo[k, j]);
            }
        }
    }
    return resultMatrix;
}

Console.Clear();
Console.WriteLine("Определяем размерность первой матрицы.");
Console.Write("Введи количество строк: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Определяем размерность второй матрицы.");
Console.Write("Введи количество строк: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = GetRandomArray(rows1, columns1);
PrintArray(firstMatrix);

Console.WriteLine();

int[,] secondMatrix = GetRandomArray(rows2, columns2);
PrintArray(secondMatrix);
Console.WriteLine();

if (rows2 != columns1)
{
    Console.WriteLine("Дружище, такие матрицы нельзя перемножать...количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
}
else
{
    Console.WriteLine("Итак, результат произведения матриц налицо:");
    int[,] multipliedMatrix = MatrixMultiplication(firstMatrix, secondMatrix, rows1, columns2);
    PrintArray(multipliedMatrix);
}
Console.ReadLine();