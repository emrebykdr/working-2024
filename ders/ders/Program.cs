Console.WriteLine("Kaç elemanlı Fibonacci serisi istiyorsunuz?");
int n = int.Parse(Console.ReadLine());
int a = 0, b = 1, c;

Console.WriteLine("Fibonacci Serisi:");
Console.WriteLine(a);
Console.WriteLine(b);

for (int i = 2; i < n; i++)
{
    c = a + b;
    Console.WriteLine(c);
    a = b;
    b = c;
}
