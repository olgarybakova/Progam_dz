// Задача 60. 
//...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента._

//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
//
// 1 метод:создать 1 мерный массив 2*2*2=8 неповторяющихся чисел
// 2 метод:создать 3-х мерный массив 2*2*2
// 3. печать массива


var rand = new Random();

var knownNumbers = new HashSet<int>();

var arr = new int[8];

for (int i = 0; i < arr.Length; i++)
{
    int newElement;
    do
    {
        newElement = rand.Next(10,99);
    } while (!knownNumbers.Add(newElement));


    arr[i] = newElement;
}

Console.Clear();
Console.Write("Mассив одномерный из неповторяющихся двузначных чисел: "+"\n");
System.Console.WriteLine(String.Join("; ",arr));
Console.WriteLine();

int[,,] nums3 = new int[2, 2, 2];

Console.Write("Mассив трехмерный [2*2*2] из неповторяющихся двузначных чисел:"+"\n");
int index=0;
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
           {
               nums3[i,j,k]=arr[index];
               index++;
             Console.Write($"{nums3[i,j,k]} ({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
    