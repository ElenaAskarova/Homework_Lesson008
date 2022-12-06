// Задать прямоугольный двумерный массив. 
// Написать программу, которая будет находить строку с наименьшей суммой элементов.

// Метод создания массива

int[,] CreateArray(int row, int column)
{
    return new int[row, column];
}

// Метод заполнения массива
 
 void FillArray(int[,] array)
 {
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = new Random().Next(1, 10);
        }
    }
 }

 // Метод, который находит строку с наименьшей суммой элементов

 void NumRowSumElements(int[,] array)
 {
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int row = 0; row < array.GetLength(1); row++) minRow += array[0, row];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++) sumRow += array[row, column];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = row;
        }
        sumRow = 0;
    }
    Console.Write($"Номер строки с наименьшей суммой элементов {minSumRow + 1} строка");
 }

// Метод вывода двумерного массива

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++) Console.Write($"{array[row, column]}");
        Console.WriteLine();
    }
}

int[,] matrix = CreateArray(4, 4);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
NumRowSumElements(matrix);