Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом");
// (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).
Console.Write("Введите число, содержащее более 4 цифр: ");
int number = Convert.ToInt32(Console.ReadLine());
int rebmun = 0;
int n = number;


while (number !=0)
        {   
            
            int reb = number % 10; 
            rebmun = rebmun * 10 + reb;
            number=number/10;
            
        }
if (rebmun==n)

    Console.Write($"Число {n} является палиндромом.");
    
else

    Console.Write($"Число {n} не является палиндромом.");
   