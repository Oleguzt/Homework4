// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int Sum(int a)
{
    int res = 0;
    for(int i = 0; i < a; i++)
    {
        res = res + a % 10;
        a = a / 10;
    }
    return res;

}

int a = EnterData("Введите число: ");
int res = Sum(a);
Console.WriteLine($"Сумма цифр в числе: {res}");