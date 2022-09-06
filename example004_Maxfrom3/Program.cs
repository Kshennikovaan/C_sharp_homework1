Console.WriteLine("Введите целое число A");
int A = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите целое число B");
int B = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите целое число C");
int C = Convert.ToInt32 (Console.ReadLine());

int max = A;

if(B > max) max = B;
if(C > max) max = C;

Console.Write("Максимальное число = ");
Console.WriteLine(max);