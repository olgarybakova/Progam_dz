// Задача 50. 
//Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет._

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4
//17 -> такого числа в массиве нет

// 1. Метод: Предложить ввести пользователю число M, N размеры массива
// 2. Метод: создаем массив размерностью [M,N]
// 3. Метод: Генерируем массив размерностью [M,N] случайных чисел
// 4. Метод поиска элемента массива по позиции
// 5. Метод печати на экран текста
// Запускаем метод 1
// запускаем метод 2
// запускаем метод 3 
// запускаем метод 4
// запускаем метод 5

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

void PrintArray(double[,] inArray) // печать массива двухмерного
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           // Console.Write($"{inArray[i, j]} ");
            Console.Write(string.Format("{0,4:0}",inArray[i, j]));
        }
        Console.WriteLine();
    }
}


Console.Clear();
SetQuantity("Задайте размер двухмерного массива");
int M = EnterNumbArray("M");
int N = EnterNumbArray("N");
double[,] a = GetArray(M,N); // нулевый массив создали

Array(a); // массив генерировали 
PrintArray(a);// печать массива

int Pow = EnterNumbArray(" позиции элемента массива");
int res=Convert.ToInt32(M*N);
    if (Pow > res-1)
    { 
       SetQuantity($"{Pow} -> такого числа в массиве нет");
    }
    else
    {
    
      int row=Convert.ToInt32(Pow/M);
      int col=(Pow % N);
              SetQuantity($" - > ({row} ; {col})");
      double res2=a[row,col];
      SetQuantity($"{res2} -> значения массива на {Pow} позиции");
   }
    
   



