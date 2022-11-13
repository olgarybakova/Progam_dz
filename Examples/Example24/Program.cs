// Задача 54: 
//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой 
//строки двумерного массива._
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
// 1.Метод вывода текста
// 2. Метод задания размерности массива
// 3. Метод создания массива
// 4. Метод генерации массива случ.чисел
// 5. Метод "пузырьковый" по убыванию по строкам 
// 6. Метод печати массива
// создаем массив случайных чисел: метод1, метод2, метод3, метод6
// формирум каждую строку по уьыванию
// метод 6


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

Double[,]  MinStrArray(double[,] inArray) //по убыванию сортировка
{
    double temp;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = j+1; k < inArray.GetLength(1); k++)
           {
            if (inArray[i,j] < inArray[i,k])
            {
                temp=inArray[i,j];
                inArray[i,j]=inArray[i,k];
                inArray[i,k]=temp;
            }
           }
        }
    }
    return inArray;
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
PrintArray(MinStrArray(a));// печать массива