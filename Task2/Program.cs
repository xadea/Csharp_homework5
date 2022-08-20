//Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int[] RandomArray(int[] array)
{
    for(int i=0; i<array.Length; i++) 
    {
        array[i] = new Random().Next(-100, 101); // я ввела ограничения, потому что иначе неудобно перепроверять, слишком большие числа

    }
    return array;
}

void OddIndexSum(int[] array)
{
    int sum = 0;
    for(int i=1; i<array.Length; i++ )
    {
        if (i%2 != 0) sum = sum + array[i];
    }

    Console.WriteLine("Odd positions sum is " + sum);
}

void Display(int[] array)
{
    Console.Write("[ ");

    for (int j = 0; j<array.Length-1; j++)
        {
            Console.Write(array[j] + ", ");
        }

    Console.WriteLine( array[array.Length-1] + " ]");
}   

int[] myarray = new int [new Random().Next(1, 11)]; // и здесь тоже ограничила количество с той же целью
RandomArray(myarray);
Display(myarray);
OddIndexSum(myarray);