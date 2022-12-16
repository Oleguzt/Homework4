//  Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B (без использования Math.Pow).
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int WithOutMathPow(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;

}
int a = EnterData("Введите число A: ");
int b = EnterData("Введите число B: ");
int res = WithOutMathPow(a,b);
Console.WriteLine($"Число {a} в степени {b} равно: {res}");

