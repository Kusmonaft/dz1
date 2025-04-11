using System;
using static System.Console;

//WriteLine("Введите размер A (длина):");
//int A = int.Parse(ReadLine());
//WriteLine("Введите размер B (ширина):");
//int B = int.Parse(ReadLine());
//WriteLine("Введите размер C (сторона квадрата):");
//int C = int.Parse(ReadLine());

//if (C > A || C > B)
//{
//    WriteLine("Невозможно разместить ни одного квадрата со стороной C.");
//}
//else
//{
//    int numSquares = (A / C) * (B / C);
//    int occupiedArea = numSquares * C * C;
//    int totalArea = A * B;
//    int unoccupiedArea = totalArea - occupiedArea;

//    WriteLine($"Количество размещенных квадратов: {numSquares}");
//    WriteLine($"Площадь незанятой части прямоугольника: {unoccupiedArea}");
//}
//decimal deposit = 10000m;
//decimal target = 11000m;

//WriteLine("Введите процент P (0 < P < 25):");
//decimal P = decimal.Parse(ReadLine());

//if (P <= 0 || P >= 25)
//{
//    WriteLine("Введите корректный процент P.");
//    return;
//}

//int months = 0;

//while (deposit <= target)
//{
//    deposit += deposit * (P / 100);
//    months++;
//}

//WriteLine($"Количество месяцев: {months}");
//WriteLine($"Итоговый размер вклада: {deposit:F2}");

//WriteLine("Введите A (A < B):");
//int A = int.Parse(ReadLine());
//WriteLine("Введите B:");
//int B = int.Parse(ReadLine());

//if (A >= B)
//{
//    WriteLine("A должно быть меньше B.");
//    return;
//}

//for (int i = A; i <= B; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Write(i + " ");
//    }
//    WriteLine();
//}

//WriteLine("Введите целое число N > 0:");
//int N = int.Parse(ReadLine());

//if (N <= 0)
//{
//    WriteLine("Число должно быть больше 0.");
//    return;
//}

//int reversedNumber = 0;
//while (N > 0)
//{
//    int digit = N % 10;
//    reversedNumber = reversedNumber * 10 + digit;
//    N /= 10;
//}

//WriteLine($"Число, прочитанное справа налево: {reversedNumber}");