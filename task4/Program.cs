//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

int Promt(string messege)
{
    Console.Write(messege);
    string strN = Console.ReadLine();
    int N =int.Parse(strN);
    return N;
}


int Number1 = Promt("Вывод четных чисел от числа "), Number2 = Promt("до числа ");




void EvenNumbers(int Number1,int Number2)
{
    if (Number1>Number2)
{
    Console.Write($"операция невозможна");
    return;
}
Console.Write($"\nчетные числа от\t{Number1} до {Number2} ->\t");
   while(Number1<=Number2)
    {
        if(Number1%2==0)
        {
           Console.Write($"{Number1} \t"); 
        }
        Number1++;
    }
}

EvenNumbers(Number1,Number2);
