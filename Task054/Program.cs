// Задать двумерный массив. 
// Написать программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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


// Метод сортировки элементов массива в строке по убыванию

void SortToLine(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            for (int m = 0; m < array.GetLength(1) - 1; m++)
            {
                if (array[row, m] < array[row, m + 1])
                {
                    int count = array[row, m + 1];
                    array[row, m + 1] = array[row, m];
                    array[row, m] = count;
                }
            }
        }
    }
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


int[,] matrix = CreateArray(3, 4);
FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(matrix);
SortToLine(matrix);
Console.WriteLine();
PrintArray(matrix);