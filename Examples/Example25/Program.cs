// Задача 56: 
//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов._

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
// Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка_

// 1.Метод вывода текста
// 2. Метод задания размерности массива
// 3. Метод создания массива
// 4. Метод генерации массива случ.чисел
// 5. Генерация одном.массива -сумма по строкам двухмерного
// 7. Нахождение минимального элем. в одномерном массиве

// создаем массив случайных чисел: метод1, метод2, метод3, метод4, метод5
// формирум в одномерн.массиве элементы =суммы по строкам
// Находим минимальный индекс номера строки(отсчет от 0)
// Вывод на печать

void SetQuantity(string text) // Вывести текст о чем либо
{
    Console.WriteLine(text);
}

int EnterNumbArray(string Name) //ввод корректности целого числа
{
    int x1;
    Console.Write($"Введите число {Name} : ");
    if (!int.TryParse(Console.ReadLine(), out x1)) // проверка на корректность ввода
    {
        do
        {
            Console.WriteLine("неправильный ввод");
            Console.Write($"введите целое число {Name}: ");
        } while (!int.TryParse(Console.ReadLine(), out x1));
    }
    return x1;
}

double[,] GetArray(int m, int n) // создание двумерного массива
{
    double[,] result = new double[m, n];
    return result;
}

void Array(double[,] inArray) //генерация массива 2-х мерного случайными числами
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            inArray[i, j] = new Random().Next(0, 100);
        }
    }
}
Double[]  ArraySum(double[,] inArray) //подсчет  суммы по строкам
{
    double[] Summ = new double[inArray.GetLength(0)];
     for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Summ[i]=0;
        for (int j = 0; j < inArray.GetLength(1); j++)
            {
            Summ[i]+= inArray[i,j];
        }
    }
    return Summ;
}

int MinArray(double[] array1)// находим минимальное значение в массиве
{
    double Min = array1[0];
    int index=0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (Min > array1[i])
        {
            Min = array1[i];
            index=i;
        }
    }
    return index;
}

void PrintArray(double[,] inArray) // печать массива двухмерного
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,4:0}",inArray[i, j]));
        }
        Console.WriteLine();
    }
}

Console.Clear();
SetQuantity("Задайте размер двухмерного массива");
int M = EnterNumbArray("строк M"); //строк всего
int N = EnterNumbArray("столбцов N"); // столбцов всего
double[,] a = GetArray(M,N); // нулевый массив создали

Array(a); // массив генерировали 
PrintArray(a);// печать массива
Console.WriteLine();
SetQuantity("Суммы по строкам (отсчет с 0): ");
System.Console.WriteLine(String.Join("; ",ArraySum(a)));
SetQuantity("Номер строки с минимальной суммой по строке: " + MinArray(ArraySum(a)));
//int MinStr = MinArray(ArraySum(a));
//Console.WriteLine(MinStr);

