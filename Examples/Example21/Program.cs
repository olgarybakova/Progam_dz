// Задача 47. 
//_Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами._

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

// 1. Метод: Предложить ввести пользователю число M, N размеры массива
// чисел для дальнейшего подсчета (см.условие задачи)
// 2. Метод: Создаем массив размерностью [M,N] случайных чисел
// 3. Метод печати на экран массива
// Запускаем метод 1
// запускаем метод 2 
// запускаем метод 3 

void SetQuantity(string text) //1. Метод: Вывести текст о чем либо
{
    Console.WriteLine(text);
}

int EnterNumbArray(string Name) //3.ввод размерности массива
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
            //Console.Write(inArray[i, j]+" ");
        }
        //Console.WriteLine();
    }
    //return inArray;
}

void PrintArray(double[,] inArray) // печать массива двухмерного
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
SetQuantity("Для создания двухмерного массива надо задать его размерность");
int M = EnterNumbArray("M");
int N = EnterNumbArray("N");
double[,] a = GetArray(M,N); // нулевый массив создали

Array(a); // массив генерировали с консоли ввода
SetQuantity($"m={M}, n={N}");
PrintArray(a);
