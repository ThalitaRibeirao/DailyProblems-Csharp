//https://judge.beecrowd.com/pt/problems/view/1153
public class Problem64
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        int fat = 1;

        for (int i = 2; i <= n; i++) fat *= i;
        Console.WriteLine(fat);
    }
}