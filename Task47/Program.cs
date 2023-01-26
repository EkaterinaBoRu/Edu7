// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*m = 3, n = 4
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse (Console.ReadLine()!);
    return userData;
}

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(data);
    Console.ResetColor();
}

double[,] generate2DArray(int colLenght, int rowLenght, int start, int end)
{
    double[,] result = new double[colLenght, rowLenght];
    for (int i=0; i< colLenght; i++)
    {
        for (int j=0; j< rowLenght; j++)
        {
           result[i,j]= new Random().Next(start, end+1) + Math.Round(new Random().NextDouble(),2);
        }
    }
    return result;
}

void print2DArray (double[,] arr)
{
    Console.Write(" \t");
    for (int j=0; j< arr.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();
    for (int i=0; i< arr.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j=0; j< arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int row = getUserData("Введите колличество строк в массиве");
int col = getUserData("Введите колличество столбцов в массиве");

double[,] array = generate2DArray(row, col, 0, 100);
print2DArray(array);
