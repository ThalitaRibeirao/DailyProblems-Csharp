//
public class Problem35
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 1000; i++)
        {
            if (i % n == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}