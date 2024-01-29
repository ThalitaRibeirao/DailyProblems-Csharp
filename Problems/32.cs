// https://www.beecrowd.com.br/judge/pt/problems/view/1072
public class Problem32
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        int QuantityIn = 0;
        int QuantityOut = 0;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x >= 10 && x <= 20) { 
                QuantityIn++;
            }
            else
            {
                QuantityOut++;
            }
        }

        Console.WriteLine($"{QuantityIn} in");
        Console.WriteLine($"{QuantityOut} out");
    }
}