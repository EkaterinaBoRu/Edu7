// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

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

void printNumber(int row, int col, int[,] arr)
{
    if (row > arr.GetLength(0) || col> arr.GetLength(1)) Console.WriteLine($"Число на позиции {row}{col}: такого числа в масссиве нет");
    else Console.WriteLine($"Число на позиции {row}{col}: {arr[row,col]}");
}
int row = getUserData("Введите строку поиска");
int col = getUserData("Введите столбец поиска");

int[,] array = generate2DArray(5, 7, 0, 100);

print2DArray(array);
printNumber(row, col, array);