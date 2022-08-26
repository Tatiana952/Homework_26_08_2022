int Acker(int m, int n)
{
    // if (m == 0) return n+1;
    // else 
    if (m > 0 && n == 0) return Acker(m-1, 1);
    else if (m > 0 && n > 0) return Acker(m-1, Acker(m, n-1));
    else return n+1;
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

while( a < 0 || b < 0)
    {
        Console.WriteLine("Only zero or positive numbers");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
    }

Console.WriteLine();
Console.WriteLine(Acker(a,b));
