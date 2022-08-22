// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] RandomArray(double[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 200 -100;
    }
    return array;
}

void DeltaMinMax (double[] array)
{
    double min = array[0], max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i]<min) min = array[i];
        if (array[i]>max) max = array[i];
    }
    Console.WriteLine(Math.Round((max-min),2));
}  

void Display(double[] array)
{
    Console.Write("[ ");

    for (int j = 0; j<array.Length-1; j++)
        {
            Console.Write(Math.Round(array[j],2) + ", ");
        }

    Console.WriteLine( Math.Round(array[array.Length-1],2) + " ]");
}   

int N = new Random().Next(1,10);
double[] myarray = new double [N];
RandomArray(myarray);
Display(myarray);
Console.Write("Difference between max and min is ");
DeltaMinMax(myarray);
 
Console.WriteLine();