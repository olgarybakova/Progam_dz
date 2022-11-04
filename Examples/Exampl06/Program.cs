//Задача 13:
//Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет._
//НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.
//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

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

int GenerAray(int Col, int number)  // метод создания массива из заданного числа
{
    int[] array = new int[Col];

    if (number < 0) number = -number;
    for (int i = Col - 1; i >= 0; i--)
    {
        array[i] = number % 10;

        Console.WriteLine(array[i]);
        number = number / 10;
    }
    return array[2];
}

Console.WriteLine("Введите целое  число");
int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(num+"/ ");
int Count1 = GetCount(num); // узнали сколько цифр в числе
{
    if (Count1 < 3)
    {
        Console.WriteLine($"{num}  -> третьей цифры нет");
    }
    else
    {
        int Res1 = GenerAray(Count1, num);
        Console.WriteLine($"{num} -> {Res1}");
    }
}