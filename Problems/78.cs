//https://judge.beecrowd.com/pt/problems/view/1176

public class Problem78
{
    public double[] GetFibonacci(double[] fibonacci, int length, int x)
    {
        for (int i = length; i <= x; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }
        return fibonacci;
    }

    public void Solve()
    {
        double[] fibonacci = new double[61];

        fibonacci[0] = 0;
        fibonacci[1] = 1;

        int length = 2;

        int n = int.Parse(Console.ReadLine()); 

        for (int i = 0; i < n; i++) { 
            int x = int.Parse((Console.ReadLine()));

            if (x > length)
            {
                fibonacci = GetFibonacci(fibonacci, length,  x);
                length = x + 1;
            }
            Console.WriteLine($"Fib({x}) = {fibonacci[x].ToString("F0")}");
        }
    }
}

