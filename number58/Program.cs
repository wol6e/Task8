// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = Prompt("Введите количество строк первой матрицы: ");
int n = Prompt("Введите количество столбцов первой матрицы, оно же количество строк второй матрицы: ");
int k = Prompt("Введите количество столбцов второй марицы: ");
int minValue = Prompt("Введите число минимального диапазона: ");
int maxValue = Prompt("Введите число максимального диапазона: ");

int[,] array1 = GetArray1(m,n,minValue,maxValue);
Console.WriteLine("Первая матрица ");
PrintArray(array1);

int[,] array2 = GetArray2(n,k,minValue,maxValue);
Console.WriteLine("Вторая матрица ");
PrintArray(array2);

int[,] resultMatrix = new int[m,k];
SuperMatrix(resultMatrix);
Console.WriteLine("Результирующая матрица ");
PrintArray(resultMatrix);

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray1(int m, int n, int min, int max)
{
    int[,] result1 = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result1[i,j] = new Random().Next(min,max);
        }
    }
    return result1;
}

int[,] GetArray2(int n, int k, int min, int max)
{
    int[,] result2 = new int[n,k];
    for(int i=0; i<n; i++)
    {
        for(int j = 0; j<k; j++)
        {
            result2[i,j] = new Random().Next(min,max);
        }
    }
    return result2;
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

 void SuperMatrix(int[,] resultMatrix)
 {
    for(int i=0; i<resultMatrix.GetLength(0); i++)
    {
        for(int j=0; j<resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for(int p=0; p<array1.GetLength(1); p++)
            {
                sum += array1[i,p]*array2[p,j];
            }
            resultMatrix[i,j] = sum;
        }
    }
 }
    
