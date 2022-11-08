﻿//  Задача 38: 
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива._

//[3 7 22 2 78] -> 76
// 1.Метод создания массива
// 2. Метод генерации массива вещественных чисел
// 3. Найти мин.элмент
// 4. Найти максимальный элемент
// 5. Найти разницу
// 6. Печать массива и результата п.5

double[] GenerAray(int Col)  // 1.метод создания массива из заданной размерности
{
    return new double[Col];
}

double[] FillAray(double[] arr)  // 2.генерирования массива случайными  числами, пусть до 2-х значных
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        arr[i] = Random.Shared.Next(-100, 100);
    }
    return arr;
}
 double MinArray(double[] array1)// находим минимальное значение в массиве
{
int count = array1.Length;
double Min=array1[0];
    for (int i = 0; i < count; i++)
    {
        if (Min> array1[i])
            Min=array1[i];
    }
    return Min;
 }

double MaxArray(double[] array1)// находим максимальное значение в массиве
{
int count = array1.Length;
double Max=array1[0];
    for (int i = 0; i < count; i++)
    {
        if (Max < array1[i])
            Max=array1[i];
    }
    return Max;
 }

void PrintAray(double[] aray)  // 4.метод печати массива 
{
    int Num1 = aray.Length;
    {
        Console.Write("[");
        for (int i = 0; i < Num1; i++)
        {
            Console.Write($"{aray[i]} ");
        }
        Console.Write($"{aray[Num1 - 1]}] ");
    }
}

Console.Clear();
Console.WriteLine("Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());


double[] a = GenerAray(num); //создали пустой массив
double[] b = FillAray(a); // заполнили случ. числами
double min=MinArray(b); // нашли минимальный элемент массива
double max=MaxArray(b); // нашли минимальный элемент массива
PrintAray(b);
Console.Write($" - >  {max-min}");

