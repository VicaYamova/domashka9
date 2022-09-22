Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
A(n, m);

static int A(int n, int m)
{
if (n == 0) return m + 1;
if (n != 0 && m == 0) return A(n - 1, 1);
if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
return A(n,m);
}
Console.WriteLine(A(n,m));