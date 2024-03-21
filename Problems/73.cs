//https://judge.beecrowd.com/pt/problems/view/1165
public class Problem73
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for(int j = 2; j <= x/2; j++)
            {
                if (x % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime) Console.WriteLine($"{x} eh primo");
            else Console.WriteLine($"{x} nao eh primo");
        }
    }
}