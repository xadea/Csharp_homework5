// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] RandArray(int[]array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

void EvenNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length ;i++)
    {
        if(array[i] % 2 == 0) count = count+1;
    }
    Console.WriteLine(" even numbers  " + count);
}

int N = new Random().Next(1,20);
int[] randomarray = new int[N];

RandArray(randomarray);

void Display(int[] array)
{
    Console.Write("[ ");

    for (int j = 0; j<array.Length-1; j++)
        {
            Console.Write(array[j] + ", ");
        }

    Console.Write(array[array.Length-1] + " ]");
}    

Display(randomarray);
EvenNumber(randomarray);
Console.WriteLine();
