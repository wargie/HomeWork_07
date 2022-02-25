// 50. В двумерном массиве n×k заменить четные элементы на противоположные

int row = 5, col = 10;

int[,] GetTable(int row, int col, int min, int max)
{
    int[,] firstTab = new int[row, col];
    for (int i = 0; i < firstTab.GetLength(0); i++)
    {
        for (int j = 0; j < firstTab.GetLength(1); j++)
        {
            firstTab[i, j] = new Random().Next(1, 11);
        }
    }
    return firstTab;
}

int[,] ReplaceEvenToSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0) array[i, j] = array[i, j] * (-1);
        }
    }
    return array;
}

void PrintTable(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int[,] firstArray = GetTable(row, col, min, max);
PrintTable(firstArray);
Console.WriteLine("-------------");
int[,] replaceArray = ReplaceEvenToSquare(firstArray);
PrintTable(replaceArray);