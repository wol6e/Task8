// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элемент 
// каждой строки двумерного массива
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой ммассив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число минимального диапазона: ");
int maxValue = Prompt("Введите число максимального диапазона: ");

int[,] array = GetArray(rows,columns,minValue,maxValue);
PrintArray(array);
Console.WriteLine();
SortRowArray(array);
PrintArray(array);

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for(int i=0; i<result.GetLength(0); i++)
    {
        for(int j = 0; j<result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(min,max+1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    int[,] arr = new int[rows,columns];
    for (int i =0; i<rows; i++)  
    {
        for(int j=0; j<columns; j++)   
        {
            Console.Write(arr[i,j]+ " ");
        }
        Console.WriteLine();
    } 
}

int[,] SortRowArray(int[,] array)
{
    int[,] SortRowArray = new int[rows,columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            for(int k=0; k<columns-1; k++)
            {
                if (array[i,k] < array[i,k+1])
                {
                    int temp = array[i,k+1];
                    array[i,k+1] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    return array;
}