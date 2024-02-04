//https://www.beecrowd.com.br/judge/pt/problems/view/1080
public class Problem38
{
    public void Solve()
    {
        int n = 0;
        int pos = 0;

        for (int i = 1; i <= 100; i++)
        {
            int aux = int.Parse(Console.ReadLine());
            if (aux > n)
            {
                n = aux;
                pos = i;
            }
        }

        Console.WriteLine(n);
        Console.WriteLine(pos);
    }
}