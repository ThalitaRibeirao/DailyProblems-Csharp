//https://judge.beecrowd.com/pt/problems/view/1145
public class Problem59
{
    public void Solve()
    {
        string[] input = Console.ReadLine().Split(' ');
        int x = int.Parse(input[0]);
        int y = int.Parse(input[1]);

        for (int i = 1; i <= y; i++)
        {
            if (i % x == 0) Console.WriteLine(i);
            else Console.Write($"{i} ");
        }
    }
}