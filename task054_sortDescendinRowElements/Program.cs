int[,] GetRandomArray(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(1, 100);
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

void SortArray(int[,] arrayToSort) // сортировка пузырьковым методом
{    
    for (int i = 0; i < arrayToSort.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToSort.GetLength(1) - 1; j++)
        {
            for (int count = j + 1; count < arrayToSort.GetLength(1); count++)
            {
                if (arrayToSort[i, j] < arrayToSort[i, count])
                {
                    int temp = arrayToSort[i, j];
                    arrayToSort[i, j] = arrayToSort[i, count];
                    arrayToSort[i, count] = temp;
                }
            }
        }
    }
}

Console.Clear();
Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] randomArray = GetRandomArray(rows, columns);
Console.WriteLine("Исходный массив");
PrintArray(randomArray);
Console.WriteLine();
Console.WriteLine("Отсортированный массив");

SortArray(randomArray);
PrintArray(randomArray);

Console.ReadLine();