// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void Array(int n)
{
    int [] array = new int [n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(0,9);
        Console.Write($"{array[i]},");
    }
}

int n = EnterData("Задайте размер массива: ");
Console.Write("[");
Array(n);
Console.WriteLine("]");


