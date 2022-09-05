// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


void FillArray(double[] collection)
{ 
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i]=new Random().Next(99, 999);
    }
}

void PrintArray(double[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.WriteLine(col[i]);
    }
}

int count = new Random().Next(1, 7);
double[] array = new double[count];

FillArray(array);
PrintArray(array);

double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length ; i++)
{
    if (array[i]>max)
    {
        max = array[i];
    }
    if (array[i]<min)
    {
        min = array[i];
    }
}

double razn = max-min;

Console.WriteLine($"Колличество элементов в массиве: {count} , разница между максимальным и минимальным элементами: {razn}");










































