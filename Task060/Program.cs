// Сформировать трёхмерный массив из неповторяющихся двузначных чисел. 
// Написать программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

// Метод создания массива

int[,,] CreateArray(int i, int j, int k)
{
    return new int[i, j, k];
}

// Метод заполнения трехмерного массива неповторяющимися двузначными числами

void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 3;
            }
        }
    }
}

// Метод печати массива с добавлением индексов каждого элемента

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] matrix = CreateArray(2, 2, 2);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
