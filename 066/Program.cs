
int Sum(int m, int n)
{
    if (m == n) return m;
    else if (m > n) return Sum(n, m-1) + m;
    else return Sum(m, n-1) + n;
}

Console.WriteLine();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(a,b));