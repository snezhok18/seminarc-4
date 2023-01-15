// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как
// задача стоит в том, чтобы написать цикл)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



// Задача 27: Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// System.Console.WriteLine("Введите число: ");
// int num21 = int.Parse(Console.ReadLine()!);
// // System.Console.WriteLine($"Введено число {num21}");
// System.Console.WriteLine($"Сумма всех цифр введенного числа равна: {Summ(num21)} ");

// int Summ(int num21)
// {
// int num22 = num21;
// int count = 0;
// while (num21 > 0)                                       // Считает количество цифр в числе.
// {
//     num21 /= 10;
//     count += 1;
// }
//                                 // System.Console.WriteLine($"В числе {count} цифр.");
// int result = 0;
// for (int i = 1; i <= count; i++)                        // Считает сумму всех цифр в числе, начиная с конца.
// {
//     int sim = num22%10;
//     num22 /=10;
//                                 // System.Console.WriteLine(sim);
//     result += sim;
// }
// return result;
// }

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