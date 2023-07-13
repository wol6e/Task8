// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаст номер строки с
// наименьшей суммой элементов: 1 строка

int m = Prompt("Введите количество строк, оно же количество столбцов: ");
int minValue = Prompt("Введите число минимального диапазона: ");
int maxValue = Prompt("Введите число максимального диапазона: ");

int[,] array = GetArray(m, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
MinRow(array);

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int m, int min, int max)
{
    int[,] result = new int[m,m];
    for(int i=0; i<m; i++)
    {
        for(int j = 0; j<m; j++)
        {
            result[i,j] = new Random().Next(min,max);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i =0; i<arr.GetLength(0); i++)  
    {
        for(int j=0; j<arr.GetLength(1); j++)   
        {
            Console.Write(arr[i,j]+ " ");
        }
        Console.WriteLine();
    } 
}

 void MinRow(int[,] array)
 {
     int minRow = 0;
     int minSumRow = 0;
     int sumRow = 0;
    for(int i=0; i<array.GetLength(1); i++)
    {
        minRow += array[0,i];
    } 
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            sumRow += array[i,j];
        }
        if(sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow =i;
        }
        sumRow = 0;
    }
    Console.Write($"Наименьшая сумма элементов в строке {minSumRow + 1}");
}
    
