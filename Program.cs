/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/


int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(100,1000);
    return result;
}

int GetDeleteSecondNumber (int number)
{
    int result = ((number / 10) % 10);
    return result;
}

int number = GetNumber();
int result = GetDeleteSecondNumber(number);

Console.WriteLine($"Было {number} стало {result}" );


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/


int numberRequest (String message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GetPrintThirdNumber (int a, int b)
{
    int result = 0;
    if (b < 3)
    {
        Console.WriteLine("третьей цифры нету ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i-- )
        {
            c = c * 10;
        }
    result = (a/c) % 10;
    }
return result;
}

int number = numberRequest("введите число ");
int count = number.ToString().Length;

Console.WriteLine(GetPrintThirdNumber(number, count));


/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

int numberRequest (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday (int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 6 || a == 7)
        {
            Console.WriteLine($"День {a} - выходной");
        }
        else
        {
            Console.WriteLine($"День {a} - рабочий ");
        }
    }
else
{
    Console.WriteLine("введите число от 1-7");
}
return "";
}

int DayNumber = numberRequest("введите число ");
Console.WriteLine(WorkHoliday(DayNumber));


