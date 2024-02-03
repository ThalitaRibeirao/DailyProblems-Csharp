//https://www.beecrowd.com.br/judge/pt/problems/view/1079
using System.Globalization;
public class Problem37
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        int[] weights = [2, 3, 5];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            double mean = 0;

            for(int j = 0; j < weights.Length; j++)
            {
                double x = double.Parse(input[j], CultureInfo.InvariantCulture);
                mean += x * weights[j];
            }
            mean /= weights.Sum();
            Console.WriteLine(mean.ToString("F1"));
        }
    }
}