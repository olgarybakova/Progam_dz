// Задача 10: Вариант1.
//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа
// 1. Метод Считать количество цифр в числе
// 2. Метод Генирировать массив размером сколько цифр в числе
// 3.Ввести  число 
// 4. вывести  заданную позицию
// 5. вывести на печать

int GetCount(int value) // метод определения количества цифр в числе
{
    if (value == 0) return 1;
    if (value < 0) value = -value;
    int result = 0;
    for (; value != 0;)
    {
        result += 1;
        value = value / 10;
    }
    return result;
}

int GenerAray(int Col, int number, int N)  // метод создания массива из заданного числа
{
    int[] array = new int[Col];

    if (number < 0) number = -number;
    for (int i = Col - 1; i >= 0; i--)
    {
        array[i] = number % 10;

        //Console.WriteLine(array[i]);
        number = number / 10;
    }
    return array[N];
}

Console.WriteLine("Введите целое  число");
int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(num+"/ ");
int Count1 = GetCount(num); // узнали сколько цифр в числе
Console.WriteLine($"всего цифр :{Count1}");

Console.WriteLine("Введите номер позиции цифры, заданного числа, отсчет слева");
int Num1 = Convert.ToInt32(Console.ReadLine());
{
    if (Num1 > 0 & Num1 <= Count1) // проверяем на корректность ввода позиции
       {
         int Res1 = GenerAray(Count1, num, Num1 - 1);

         Console.WriteLine($"Позиция № :{Num1} в заданном числе: {num} -> {Res1}");
       }
        
     else
        {
         Console.WriteLine("Такой позиции нет ");
        }
    }


