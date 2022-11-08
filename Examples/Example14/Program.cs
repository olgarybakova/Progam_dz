//  Задача 27:
//Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе._

//452 -> 11

//82 -> 10

//9012 -> 12

//1.Ввода числа
//2.Метод определения количества цифр в числе
//3. Метод генерации массива из цифр числа
//4.Метод сложения элементов чисел в массиве
//5.Печать результата

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
int GetSum(int[] arr) // метод определения суммы цифр в числе с помощью массива
{
    int Num1 = arr.Length;
    int res=0;
    {
         for (int i = 0; i < Num1; i++)
              res = res+arr[i];
            }
    return res;
}
Console.WriteLine("Введите целое  число");
int num = Convert.ToInt32(Console.ReadLine());
int count=GetCount(num);
int[] a=GenerAray(count,num);


Console.Write($"{num} - >  {GetSum(a)}"); 
