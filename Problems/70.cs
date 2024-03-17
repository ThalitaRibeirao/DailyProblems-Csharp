//https://judge.beecrowd.com/pt/problems/view/1159
using System.Globalization;
public class Problem70
{
    public void Solve()
    {
        while (true)
        {
            int x = int.Parse(Console.ReadLine());

            if (x == 0) break;

            if (x*x % 2 == 1) x++;
            int sum = (x + 4) * 5;
            Console.WriteLine(sum);
        }
    }
}