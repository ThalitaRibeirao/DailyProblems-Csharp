//https://judge.beecrowd.com/en/login
public class Problem45
{
    public void Solve()
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            if (n <= 0 || m <= 0) break;
            else
            {
                if (n > m)
                {
                    int aux = n;
                    n = m;
                    m = aux;
                }
                int sum = (n + m) * (m - n + 1)/2;

                for (int i = n; i <= m; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine($"Sum={sum}");
            }
        }
    }
}