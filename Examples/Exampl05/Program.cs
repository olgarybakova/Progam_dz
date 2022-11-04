// Задача 10: 
//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа
// 1. Метод Считать количество цифр в числе
// 2. Ввести  число 
// 3.Генирировать массив размером сколько цифр в числе
// 4. Метод из массива вывести цифру по заданной позиции 
//

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

int  GenerAray(int Col, int number, int N)
{
    int[] array = new int[Col];

    if (number < 0) number = -number;
    for (int i = Col - 1; i >= 0; i--)
    {
        array[i] = number % 10;

        Console.WriteLine(array[i]);
        number = number / 10;
    }
     return array[N];
}

Console.WriteLine("Введите целое  число");
int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(num+"/ ");
int Count1 = GetCount(num); // узнали сколько цифр в числе

Console.WriteLine($"всего цифр :{Count1}");

int Res1 = GenerAray( Count1, num, 1);

Console.WriteLine($"Позиция № 1 :{Res1}");


