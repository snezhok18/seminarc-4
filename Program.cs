// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как
// задача стоит в том, чтобы написать цикл)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Random rnd = new Random();
int num1 = rnd.Next(10);
int num2 = rnd.Next(10);

Console.WriteLine($"Число {num1} в степени {num2} равно {GetMult(num2)}.");

if (num2 == 0)
{
    Console.WriteLine($"Число {num1} в степени {num2} равно 1.");
}

int GetMult(int num2)
{
int result = num1;
for (int i = 1; i < num2; i++)
{
    result = result*num1;
}
return result;
}

// Задача 27: Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Ведите число: ");
int num21 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма всех цифр введенного числа равна: {Summ(num21)}");

int Summ(int num21)
{
    int num22 = num21;
    int count = 0;
    while (num21 > 0)
    {
        num21 /=10;
        count +=1;        
    }
    int result = 0;
    for (int i = 1; i <= count; i++)
    {
        int sim = num22%10;
        num22 /=10;
        result +=sim;
    }
    return result;
}

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран. (числа берете любые)

int[] Array = GetArray(8);
Console.WriteLine($"{String.Join(", ", Array)}");

int[] GetArray(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(11);
    }
    return Array;
}