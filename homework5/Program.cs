/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] CreateArray(int size)
{
    return new int[size];
}

string Print(int[] array)
{
    string result = String.Empty;
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
        result = result + " " + array[index];
        index++;
    }
    return result;
}
int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetNumber("Введите размер массива");
int[] numbers = CreateArray(size);

void FillArray(int[] numbers)
{

    Random rand = new Random();
    for (int i = 0; i < size; i++)
        numbers[i] = rand.Next(10);
}
void ChetValue(int[] numbers)
{
    int i = 1;
    int t = 0;
    while (i < numbers.Length)
    {
        t = t + numbers[i];
        i = i + 2;
    }
    Console.WriteLine(t);

}
FillArray(numbers);
Console.WriteLine(Print(numbers));
ChetValue(numbers);


/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/



int[] CreateArray(int size)
{
    return new int[size];
}

string Print(int[] array)
{
    string result = String.Empty;
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
        result = result + " " + array[index];
        index++;
    }
    return result;
}
int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetNumber("Введите размер массива");
int[] numbers = CreateArray(size);

void FillArray(int[] numbers)
{

    Random rand = new Random();
    for (int i = 0; i < size; i++)
        numbers[i] = rand.Next(100, 999);
}

FillArray(numbers);
Console.WriteLine(Print(numbers));

void EvenNumbers(int[] numbers)
{
 int i = 0;
 int result = 0;
 while(i < numbers.Length)
 {
    if(numbers[i] % 2 == 0 )
    {
        result++;
    }
    i++;
 }
Console.WriteLine($"Четных чисел в массиве " + result);

}

EvenNumbers(numbers);


/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double[] CreateArray(int size)
{
    return new double[size];
}

string Print(double[] array)
{
    string result = String.Empty;
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
        result = result + " " + array[index];
        index++;
    }
    return result;
}
int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetNumber("Введите размер массива");
double[] numbers = CreateArray(size);

void FillArray(double[] numbers)
{

    Random rand = new Random();
    for (int i = 0; i < size; i++)
        numbers[i] = Convert.ToDouble(rand.Next(100) / 10.0);
}


FillArray(numbers);
Console.WriteLine(Print(numbers));


void Difference(double [] numbers)
{
 int i = 0;
    double min = numbers[i];
    while (i < numbers.Length)

    {
        if (numbers[i] < min)
        {
            min = numbers[i];

        }
        i++;
    }
    Console.WriteLine($"Минимальный эллемент массива " + min);

     int j = 0;
    double max = numbers[j];
    while (j < numbers.Length)

    {
        if (numbers[j] > max)
        {
            max = numbers[j];

        }
        j++;
    }
    Console.WriteLine($"Максимальный эллемент массива " + max);

    double result = max - min;
Console.WriteLine($"Разница " + result);
}

Difference(numbers);

