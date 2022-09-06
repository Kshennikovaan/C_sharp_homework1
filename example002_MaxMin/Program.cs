
Console.WriteLine("Введите целое число A");
int A = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите целое число B");
int B = Convert.ToInt32 (Console.ReadLine());

int max = A;
int min = B;

if(B > A) 
{
    max = B;
    min = A;
}
else 
{
    max = A;
    min = B;
}

Console.Write("Максимальное число = ");
Console.WriteLine(max);
Console.Write("Минимальное число = ");
Console.WriteLine(min);