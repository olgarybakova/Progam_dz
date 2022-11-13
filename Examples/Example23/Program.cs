// # Задача 52. 
//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце._

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// 1. Метод: Предложить ввести пользователю число M, N размеры массива
// 2. Метод: создаем массив размерностью [M,N]
// 3. Метод: Генерируем массив размерностью [M,N] случайных чисел
// 4. Метод расчета по столбцу(строке) среднего арифмитического
// 5. Печать на экран результата
// Запускаем метод 1
// запускаем метод 2
// запускаем метод 3 
// запускаем метод 4 
// запускаем  5

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

Double[]  ArrayMidlSum(double[,] inArray) //подсчет среднеарифметической суммы по столбцам
{
    double[] MidlSumm = new double[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        MidlSumm[j]=0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            MidlSumm[j]+= inArray[i,j];
        }
        MidlSumm[j]= MidlSumm[j]/inArray.GetLength(0);
    }
    return MidlSumm;
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
int M = EnterNumbArray("M"); //строк всего
int N = EnterNumbArray("N"); // столбцов всего
double[,] a = GetArray(M,N); // нулевый массив создали

Array(a); // массив генерировали 
PrintArray(a);// печать массива
SetQuantity("Среднее арифметическое элементов по  каждому столбцу: ");
System.Console.WriteLine(String.Join("; ",ArrayMidlSum(a))); // печать среднеар.суммы
