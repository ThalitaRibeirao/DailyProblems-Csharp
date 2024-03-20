//https://judge.beecrowd.com/pt/problems/view/1164
using System.Xml;

public class Problem72 { 
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int j = 1; j <= x/2; j++)
            {
                if (x % j == 0) sum += j;
            }

            if (sum == x) Console.WriteLine($"{x} eh perfeito");
            else Console.WriteLine($"{x} nao eh perfeito");
        }
    }
}