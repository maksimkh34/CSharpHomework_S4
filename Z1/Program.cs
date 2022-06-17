int power(int n, int m)
{
    int result = n;
    while(m>1)
    {
        result = result * n;
        m--;
    }
    return result;
}

Console.Write("Enter A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Answer is: " + power(a, b));
//Console.Write("Answer is: " + Math.Pow(a, b));