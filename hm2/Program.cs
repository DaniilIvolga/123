/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*int metod (string massage)
{
Console.Write(massage);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}
int number = metod("Введите число");
if (number < 100 && number >= 1000)
{
   Console.WriteLine("Число не подходит, пожалуйста, введите другое.");
   return;
 
}
Console.WriteLine("Введите число");
int second = number / 10 % 10;
Console.WriteLine($"Вторая цифра '{second}'");
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
/*
int metod(string massage)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int thirdrank(int number)
{
while (number < 1000)
{
    number /= 10;
}
return number % 10;
}
bool validnumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Нет третьей цифры");
        return false;
    }
    return true;
}
int number = metod("Введите число > ");
if (validnumber(number))
{
    Console.WriteLine(thirdrank(number));
}
*/

/*int metod(string message)
{
    Console.Write(message);
    string value =  Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool isWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
return false;
}
bool ValidateWeekDay(int number)
{
    if (number > 0 && number <= 7 )
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}
int weekDay = metod("Введите день недели> ");
if (ValidateWeekDay(weekDay))
{
    if (isWeekend(weekDay))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Придется поработать");
    }
}
*/