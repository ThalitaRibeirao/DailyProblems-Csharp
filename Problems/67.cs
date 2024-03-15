//https://judge.beecrowd.com/pt/problems/view/1156
public class Problem67
{
    public void Solve()
    {
        //Console.WriteLine("6.00");
        //return;
        double sum = 0;

        for (int i = 0; i < 20; i ++)
        {
            double odd = 1 + 2 * i;
            double pot = Math.Pow(2, i);
            sum += (double) odd / pot;
        }
        Console.WriteLine(sum.ToString("F2"));
    }
}