// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] get2DIntArray(int rowLength, int  colLength, int start, int end)
{
   int[,] array = new int[rowLength, colLength];
   for (int i = 0; i < rowLength; i++)
   {
        for (int j = 0; j < colLength; j++)
        {
            array[i,j] = new Random().Next(start, (end+1));
        }
   }
   return array; 
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color; 
    Console.Write(data);
    Console.ResetColor();
}
void printHeadOfArray(int length)
{
    Console.Write(" \t");
    for (int i = 0; i < length; i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}
void print2DArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t", ConsoleColor.Cyan); 
       for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
    Console.WriteLine("--------------------------------------------");
}
int getUserData(string message)
{
   printInColor(message + "\n",ConsoleColor.DarkGreen);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
int[,] selectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if(array[i,j]>= array[i,k])
                {
                    int tmp = array [i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = tmp;
                }
            }
        }
    }
    return array;
}
int rows = getUserData("Введите количество строк");
int cols = getUserData("Введите количество столбцов");
int[,] array = get2DIntArray(rows, cols, 0, 10);
print2DArray(array);
int[,] sortedArray = selectionSort(array);
print2DArray(sortedArray);
