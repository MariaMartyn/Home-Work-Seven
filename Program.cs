/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/
/*
double[,] CreateRandom2dArray(int m, int n, int minValue, int maxValue)
{
    
    double[,] newArray = new double[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue+1) + new Random().NextDouble();
    return (newArray);
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]:f2}   ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input numbers of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, minValue, maxValue);
Show2dArray(myArray);
*/

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.*/
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue+1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindElementInPosition(int[,] array)
{
    Console.Write("Input position of rows (start from 0): ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input position of columns (start from 0): ");
    int b = Convert.ToInt32(Console.ReadLine());
    
    int result = 0;
    if (a < 0 || a>array.GetLength(0) || b<0 || b>array.GetLength(1)) 
        Console.Write("This element is mising.");
    else 
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {            
                if ((a==i) && (b==j)) result = array[i,j];
            }
        }
    return result;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int newRes = FindElementInPosition(myArray);
if (newRes != 0) 
    Console.WriteLine($"Element with input index is {newRes}");
*/


/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue+1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindMeanColumn(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
      double sum = 0;
      double mean = 0;
      Console.Write("Mean of columns is: ");  
    for (int j = 0; j < array.GetLength(1); j++) 
    {   
        double count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {   
            sum = sum + array[i,j];
            count ++;
        }
        mean = sum/count; 
        sum = 0;
        newArray[j] = mean;
        Console.Write($"{newArray[j]:f2} ");
    }
    
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

//double[] newArray = FindMeanColumn();
FindMeanColumn(myArray);
*/