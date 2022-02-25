// Задача 52: В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.WriteLine();
Console.WriteLine("Дан двумерный массив");
Console.WriteLine();

int row = 5, col = 5;

int[,] GetArray(int row, int col)
    {
        int[,] array = new int[row, col];
            for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                        {
                            array[i, j] = new Random().Next(1, 10);
                        }
                }
            return array;
    }

int[,] ChangeToSquareEvenIndex(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (i % 2 == 0 && j % 2 == 0) arr[i, j] *= arr[i, j];
                        else arr[i, j] = arr[i, j];
                    }
            }
        return arr;
    }

void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < 10) Console.Write($" {array[i, j]}   ");
                        else Console.Write($"{array[i, j]}   ");
                    }
                Console.WriteLine();
            }
    }

int[,] mainArray = GetArray(row, col);
PrintArray(mainArray);

Console.WriteLine();
Console.WriteLine("Массив с заменой чётных элементов на их квадраты");
Console.WriteLine();

int[,] chagedArray = ChangeToSquareEvenIndex(mainArray);
PrintArray(chagedArray);