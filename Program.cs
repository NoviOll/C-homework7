// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
int m = 3;
int n = 4;
double[,] array = new double[m, n];
FillArray(array);
void FillArray(double[,] numbers)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers[i, j] = Convert.ToDouble(new Random().Next(-10, 10));
        }
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}
    

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите строку искомого элемента");
int a = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите столбец искомого элемента");
int b = Convert.ToInt32(Console.ReadLine()) - 1;
int m = 3;
int n = 4;
double[,] array = new double[m, n];
FillArray(array);
void FillArray(double[,] numbers)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers[i, j] = Convert.ToDouble(new Random().Next(-10, 10));
        }
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}
if (a <= m && b <= n)
{
    Console.WriteLine(array[a, b]);
}
else
{
    Console.WriteLine("Такого элемента нет");
}
 

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int m = 4;
int n = 4;
double[,] array = new double[m, n];
FillArray(array);
void FillArray(double[,] numbers)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers[i, j] = Convert.ToDouble(new Random().Next(-10, 10));
        }
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}
for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += array[i, j];
    }
    Console.Write(sum / m + " ");
}