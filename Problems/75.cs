//https://judge.beecrowd.com/pt/problems/view/1173
public class Problem75
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"N[{i}] = {n}");
            n *= 2;
        }
    }
}
