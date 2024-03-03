//https://judge.beecrowd.com/pt/problems/view/1144
using System.Dynamic;

public class Problem58
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < 2*n; i++)
        {
            double div = 1 + (i/2);
            double rest = i % 2;
            double x = div;
            double y = Math.Pow(div, 2) + rest;
            double z = Math.Pow(div, 3) + rest;
            Console.WriteLine($"{x.ToString("F0")} {y.ToString("F0")} {z.ToString("F0")}");
        }
    }
}