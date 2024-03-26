//https://judge.beecrowd.com/pt/problems/view/1174
public class Problem76
{
    public void Solve()
    {
        double[] vector = new double[200];
        int n = 0;

        for (int i = 0; i < 100; i++)
        {
            double x = double.Parse(Console.ReadLine());

            if (x <= 10)
            {
                vector[n] = i;
                vector[n + 1] = x;
                n += 2;
            }
        }

        for (int i = 0; i < n; i += 2)
        {
            Console.WriteLine($"A[{vector[i].ToString("F0")}] = {vector[i + 1].ToString("F1")}");
        }
    }
}