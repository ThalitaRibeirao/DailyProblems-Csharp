//https://judge.beecrowd.com/pt/problems/view/1160
using System.Globalization;
public class Problem71
{
    public void Solve()
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++) {
            string[] input = Console.ReadLine().Split(' ');
            double pa = int.Parse(input[0]);
            double pb = int.Parse(input[1]);
            double g1 = 1 + double.Parse(input[2], CultureInfo.InvariantCulture)/100;
            double g2 = 1 + double.Parse(input[3], CultureInfo.InvariantCulture) /100;


            double years = 0;
            while(pa <= pb && years <= 100 )
            {
                pa = Math.Floor(pa*g1);
                pb = Math.Floor(pb*g2);
                years++;
            }

            if (years > 100) Console.WriteLine("Mais de 1 seculo.");
            else Console.WriteLine($"{years} anos.");
        }
    }
}