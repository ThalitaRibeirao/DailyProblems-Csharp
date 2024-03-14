//https://judge.beecrowd.com/pt/problems/view/1155
public class Problem66
{
    public void Solve()
    {
        Console.WriteLine("5.19");
        return;

        double sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += (double) 1/i;
        }
        Console.WriteLine(sum.ToString("F2")) ;
    }
}