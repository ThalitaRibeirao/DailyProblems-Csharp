//https://judge.beecrowd.com/pt/problems/view/1150
public class Problem62
{
    public void Solve()
    {
        int x = int.Parse(Console.ReadLine());
        int z;

        while (true)
        {
            z = int.Parse(Console.ReadLine());
            if (z > x) break;
        }

        int sum = x;
        int i = 1;

        while (true)
        {
            if (sum > z) break;
            sum += x + i;
            i++;
        }
        Console.WriteLine(i);
    }
}