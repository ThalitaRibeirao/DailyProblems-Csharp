//https://judge.beecrowd.com/pt/problems/view/1117
using System.Globalization;

public class Problem50
{
    public void Solve()
    {
        double[] grades = new double[2];
        int lenght = 0;
        while (lenght< 2)
        {
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (x < 0 || x > 10) Console.WriteLine("nota invalida");
            else grades[lenght++] = x;
        }
        double mean = grades.Sum() / lenght;
        Console.WriteLine($"media = {mean.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}