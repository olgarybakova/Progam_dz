// Задача 29: 
//Напишите программу, которая задаёт массив из N элементов и выводит их на экран._

//N = 5, получаем массив [1, 2, 5, 7, 19]

//N = 3, получаем массив [6, 1, 33]
// 1.Ввод числа
//2. Генерация массива
// 3. печать массива

int[] GenerAray(int Col)  // метод создания массива из заданного числа
{
    int[] array = new int[Col];

       for (int i = 0; i < Col; i++)
       {
        array[i] = new Random().Next(0,100);
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


int[] a=GenerAray(num);

Console.Write($"{num} - >  ");
PrintAray(a);