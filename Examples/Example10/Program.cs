//Задача 23
//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
// 1.  Метод Генирировать массив размером заданного числа N
// и Заполнить массив ( в кубе каждое число ,начиная 1 до N)
// 3. Метод печати массива
// 3. Ввести  число 
// 4. Вызвать метод1
// 5. Вызвать метод2

int[] GenerAray(int number)  // метод создания массива 
{
    int[] array = new int[number];
    for (int i = 0; i < number ; i++)
    {
        array[i] = (i+1) * (i+1) * (i+1);
        //Console.Write($"{array[i]} , ");
    }
    return array;
}
void PrintAray(int[] aray2)  // метод печати массива 
{
    int Num1 = aray2.Length;
    {
         for (int i = 0; i < Num1-1; i++)
    {
        Console.Write($"{aray2[i]} , ");
    }
         Console.Write(aray2[Num1-1]);
    }
       
}
Console.WriteLine("Введите целое  число");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} - >  ");

int[] a=GenerAray(num);
PrintAray(a);