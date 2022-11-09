//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.WriteLine("Введите число:");
int Number = int.Parse(Console.ReadLine()!);
OutputDigitSum(Number);

int OutputDigitSum(int Number)
{

    int Sum = 0;
    while (Number > 0)
    {
        Sum = Sum + Number % 10;
        Number = Number / 10;
    }

    Console.WriteLine ("Сумма цифр в числе: " + Sum);
    return Sum;
}


