// Задача 48: Показать двумерный массив размером m×n заполненный целыми числами

int[,] GetTable(int row, int col)
{
    int[,] table = new int[row, col];
    for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
                {
                    table[i, j] = new Random().Next(-100, 101);
                }
        }
    return table;
}

void PrintTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
            Console.WriteLine();
        }
}

int row = new Random().Next(2, 30);
int col = new Random().Next(2, 30);

int[,] arr = GetTable(row, col);
PrintTable(arr);