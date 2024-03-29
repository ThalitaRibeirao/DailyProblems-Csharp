//https://judge.beecrowd.com/pt/problems/view/1177
public class Problem79
{
    public void Solve()
    {
        int t = int.Parse(Console.ReadLine());

        for(int i = 0; i < 1000; i++)
        {
            Console.WriteLine($"N[{i}] = {i%t}");
        }
    }
}