Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

Console.WriteLine("Введите число:");
int N=Convert.ToInt32(Console.ReadLine());

double Func(int N)
{
    return N = Convert.ToInt32(Math.Pow(N, 3));    
}

int i=1;
while (i<=N)
{
    Console.Write(Func(i));
    if (i<N)
        Console.Write(", ");
    i++;
}

