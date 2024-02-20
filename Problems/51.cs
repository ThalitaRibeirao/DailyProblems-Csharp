//https://judge.beecrowd.com/pt/problems/view/1118
using System.Globalization;
using System.Linq;
public class Problem51
{
    public void Solve()
    {
        while (true)
        {
            double[] grades = new double[2];
            int length = 0;

            while(length < 2)
            {
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (x < 0 || x > 10) Console.WriteLine("nota invalida");
                else grades[length++] = x;
            }
            double average = grades.Sum() / length;
            Console.WriteLine($"media = {average.ToString("F2", CultureInfo.InvariantCulture)}");
            
            while (true)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                int option = int.Parse(Console.ReadLine());

                if (option == 1) break;
                else if (option == 2) return;
            }

        }
    }
}