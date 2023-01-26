// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

int[,] generate2DArray(int colLenght, int rowLenght, int start, int end)
{
    int[,] result = new int[colLenght, rowLenght];
    for (int i=0; i< colLenght; i++)
    {
        for (int j=0; j< rowLenght; j++)
        {
           result[i,j]= new Random().Next(start, end+1);
        }
    }
    return result;
}
void print2DArray (int[,] arr)
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

void searchAverageCol(int[,] arr)
{
    double average = 0;
    Console.WriteLine($"Cреднее арифметическое чисел в каждом столбце:");
    for (int j=0; j< arr.GetLength(1); j++)
    {
        for (int i=0; i< arr.GetLength(0); i++)
        {
           average = average + arr[i,j];
        }
        Console.WriteLine(Math.Round(average/arr.GetLength(0),2));
        average = 0;
    }
}

int row = getUserData("Введите колличество строк в массиве");
int col = getUserData("Введите колличество столбцов в массиве");

int[,] array = generate2DArray(row, col, 0, 5);

print2DArray(array);
searchAverageCol(array);