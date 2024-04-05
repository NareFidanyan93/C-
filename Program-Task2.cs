// Задача 2: Напишите программу 
// вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.


void Main()
{
    int m = ReadInt("Введите число m : ");
    int n = ReadInt("Введите число n : ");
    Akkerman (m , n);
    Console.Write(Akkerman(m , n));
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
     if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();
