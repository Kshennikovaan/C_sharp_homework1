Console.WriteLine("Введите целое число N больше или равное 2");
int N = Convert.ToInt32 (Console.ReadLine());

try
{
    int i = 2;
    while (i <= N)
    {
        Console.Write (i+ ",");
        i = i +2;
    }
}

catch
{
    Console.WriteLine( "Число целое");
}

if( N < 2) 
{
    Console.WriteLine( "Требовалось ввести корректное число. Попробуйте снова.");
}