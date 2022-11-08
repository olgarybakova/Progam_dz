// Задача 34: 
//Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве._
//[345, 897, 568, 234] -> 2
//1.Метод создания нового массива
//2.Метод генерирования массива случайными 3х значными числами
//3. Метод счета четных чисел
//4.Печать результата
//5. Клиентский код: ввод размера массива и далее по списку методы

int[] GenerAray(int Col)  // 1.метод создания массива из заданной размерности
{
    return new int[Col];
}

int[] FillAray(int[] arr)  // 2.генерирования массива случайными 3х значными числами
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

int CountDouble(int[] array) //3.Метод подсчета количества четных чисел
{
    int index = 0;
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (array[i] % 2 == 0)
        {
            index+=1;
        }
    }
   return index;
}

void PrintAray(int[] aray)  // 4.метод печати массива 
{
    int Num1 = aray.Length;
    {
        Console.Write("[");
        for (int i = 0; i < Num1 - 1; i++)
        {
            Console.Write($"{aray[i]}, ");
        }
        Console.Write($"{aray[Num1 - 1]}] ");
    }
}

Console.Clear();
Console.WriteLine("Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());


int[] a = GenerAray(num); //создали пустой массив
int[] b = FillAray(a); // заполнили случ.3х значными числами
int Res=CountDouble(b);
PrintAray(b);
Console.Write($" - >  {Res}");
