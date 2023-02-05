// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int SumNumAmmount (int S)
{
    int count = 0;
    int N = S;
    while (S > 0)
        {
            N = S % 10;
            count = N + count;
            S = S / 10;
        }    
    return count;
}

Console.Write("Введите число: ");
int S = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе равна = {SumNumAmmount(S)}");