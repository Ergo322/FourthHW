Console.Write ("Введите число: ");
int A  = Convert.ToInt32 (Console.ReadLine());

int SumA(int A)
{
    int massiv = Convert.ToString(A).Length;
    int count = 0;
    int result = 0;
        for (int i = 0; i < massiv; i++)
        {
            count = A - A % 10;
            result = result + (A - count);
            A = A / 10;
        }
        return result;
}
int sumNumber = SumA(A);
Console.WriteLine ($"Сумма цифр в числе: {sumNumber}" );