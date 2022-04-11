//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

int Promt(string messege)
{
    Console.Write(messege);
    string strN = Console.ReadLine();
    int N =int.Parse(strN);
    return N;
}
int Number1 = Promt("от "), Number2 = Promt("до ");
if (Number1>Number2)
{
    Console.Write($"нет решения");
    return;
}

int SumNumbers(int Number1,int Number2)
{
int sum=0;
   for(int i =Number1; i<=Number2;i++)
    {
        sum +=Number1;
      Number1++;
    }
    return sum;
}
Console.Write($"сумма чисел равна-> {SumNumbers(Number1,Number2)}");
