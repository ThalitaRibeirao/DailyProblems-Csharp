//https://judge.beecrowd.com/pt/problems/view/1113
public class Problem46
{
    public void Solve()
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            if (x == y) break;
            else
            {
                if (x < y) Console.WriteLine("Crescente");
                else Console.WriteLine("Decrescente");
            }
        }
    }
}