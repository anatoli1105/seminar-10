//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
//m = 3, n = 2 -> A(m,n) = 29
// функция Аккермана
int Promt(string messege)
{
    Console.Write(messege);
    string strN = Console.ReadLine();
    int N =int.Parse(strN);
    return N;
}
int NumberAckerman = 0;
void Сondition1(int column,int row)
{
if(column == 0 || column ==1)
{
    column+=1;
    NumberAckerman = row + column;
    Console.WriteLine(NumberAckerman);
    return;
}
}

void Сondition2(int column,int row)
{
if(column==2)
{
    NumberAckerman=2*row + 3;
    Console.WriteLine(NumberAckerman);
    return;
}
}
void Сondition3(int column,int row)
{
int x= 1;
if(column==3)
{
row+=column;
for (int i = 0;i<row;i++)
{
 x*=2;
}
NumberAckerman=x-3;
Console.WriteLine(NumberAckerman);
}
}
int column = Promt("m -> "), row = Promt("n-> ");
Сondition1(column,row);
Сondition2(column, row);
Сondition3(column,row);
