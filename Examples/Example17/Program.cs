// Задача 36:
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях._

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
// 1.Метод создания нового массива
//2.Метод генерирования массива случайными числами
//3. Метод расчет суммы элементов на  нечетных позициях
//4.Печать результата
//5. Клиентский код: ввод размера массива и далее по списку методы

int[] GenerAray(int Col)  // 1.метод создания массива из заданной размерности
{
    return new int[Col];
}

int[] FillAray(int[] arr)  // 2.генерирования массива случайными  числами, пусть до 2-х значных
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Random.Shared.Next(-100, 100);
    }
    return arr;
}

int CountSum(int[] array) //3.Метод подсчета суммы элементов массива на нечетных позициях
{
    int count = array.Length;
    int Sum = 0;
    if (count % 2 != 0) count = count - 1;
    for (int i = 1; i < count; i += 2)
    {
        Sum += array[i];
    }
    return Sum;
}

void PrintAray(int[] aray)  // 4.метод печати массива 
{
    Console.Write("[");
    for (int i = 0; i < aray.Length - 1; i++)
    {
        Console.Write($"{aray[i]}, ");
    }
    Console.Write($"{aray[aray.Length - 1]}] ");

}

Console.Clear();
Console.WriteLine("Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());


int[] a = GenerAray(num); //создали пустой массив
int[] b = FillAray(a); // заполнили случ. числами
int summa = CountSum(b); // посчитали сумму членов массива на нечетных позициях
PrintAray(b);
Console.Write($" - >  {summa}");
