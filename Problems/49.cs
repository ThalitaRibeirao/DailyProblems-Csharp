//https://judge.beecrowd.com/pt/problems/view/1116
using System.Globalization;
public class Problem49
{
    public void Solve()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);

            if (y == 0) Console.WriteLine("divisao impossivel");
            else
            {
                double div = x / y;
                string divString = div.ToString("F1", CultureInfo.InvariantCulture);
                Console.WriteLine(divString);
            }
        }
    }
}