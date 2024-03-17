//https://judge.beecrowd.com/pt/problems/view/1158
public class Problem69
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++) {
            string[] input = Console.ReadLine().Split(' ');
            double x = int.Parse(input[0]);
            double y = int.Parse(input[0]);
            y = int.Parse(input[1]);

            if (x % 2 == 0) x++;

            double sum = (2*x + 2*(y - 1)) *(y/2);
            Console.WriteLine(sum.ToString("F0"));
        }
    }
}