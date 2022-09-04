// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void KUB()
{
    Console.Write ("Введите число которое надо возвести в степень: ");
    int A = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите степень: ");
    int B = Convert.ToInt32 (Console.ReadLine());
    int count = 0;
    int result = A;
    while (count<(B-1))
    {
        result = result*A;
        count++;
    }
    Console.WriteLine ($"{A}, {B} -> {result}");
}
KUB();

