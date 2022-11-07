//Задача 19
//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
//1.Ввода числа
//2.Метод определения количества цифр в числе
//3. Метод генерации массива из цифр числа
//4.Метод определения четности числа 
//5.Метод проверки палиндромности

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

int[] GenerAray(int Col, int number)  // метод создания массива из заданного числа
{
    int[] array = new int[Col];

    if (number < 0) number = -number;
    for (int i = Col - 1; i >= 0; i--)
    {
        array[i] = number % 10;
        number = number / 10;
    }
    return array;
}

Console.WriteLine("Введите целое  число");
int Number = Convert.ToInt32(Console.ReadLine());
int Count1 = GetCount(Number); // узнали сколько цифр в числе
int[] a = GenerAray(Count1, Number); // создали массив из цифр числа
string flag = " -> да";
{
    for (int i = 0; i < Count1 / 2; i++)
    {
        if (a[i] != a[Count1 - i - 1])
            flag = " -> нет"; // здесь, конечно, можно и прервать цикл: break
    }
}
Console.WriteLine(flag);


